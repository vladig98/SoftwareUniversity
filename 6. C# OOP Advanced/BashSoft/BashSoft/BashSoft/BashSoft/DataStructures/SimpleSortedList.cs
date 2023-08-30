using BashSoft.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BashSoft.DataStructures
{
    public class SimpleSortedList<T> : ISimpleOrderedBag<T> where T : IComparable<T>
    {
        private const int DefaultSize = 16;

        private T[] innerCollection;
        private int size;
        private IComparer<T> comparison;

        private void InitiliazeInnerCollection(int capacity)
        {
            if (capacity < 0)
            { 
                throw new ArgumentException("Capacity cannot be negative!");
            }

            innerCollection = new T[capacity];
        }

        public SimpleSortedList(IComparer<T> comparer, int capacity)
        {
            comparison = comparer;
            //size = capacity;
            InitiliazeInnerCollection(capacity);
        }

        public int Capacity
        {
            get { return innerCollection.Length; }
        }

        public SimpleSortedList(int capacity) : this(Comparer<T>.Create((x, y) => x.CompareTo(y)), capacity)
        {
        }

        public SimpleSortedList(IComparer<T> comparer) : this(comparer, DefaultSize)
        {
        }

        public SimpleSortedList() : this(Comparer<T>.Create((x, y) => x.CompareTo(y)), DefaultSize)
        {
        }

        public bool Remove (T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException();
            }

            bool hasBeenRemoved = false;

            int indexOfRemovedElement = 0;

            for (int i = 0; i < Size; i++)
            {
                if (innerCollection[i].Equals(element))
                {
                    indexOfRemovedElement = i;
                    innerCollection[i] = default(T);
                    hasBeenRemoved = true;
                    break;
                }
            }

            if (hasBeenRemoved)
            {
                for (int i = indexOfRemovedElement; i < Size - 1; i++)
                {
                    innerCollection[i] = innerCollection[i + 1];
                }

                innerCollection[Size - 1] = default(T);

                size--;
            }

            return hasBeenRemoved;
        }

        public int Size
        {
            get { return size; }
        }

        public void Add(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException();
            }

            if (innerCollection.Length <= Size)
            {
                Resize();
            }

            innerCollection[size] = element;
            size++;

            innerCollection = innerCollection.Where(x => x != null).ToArray();
            size = innerCollection.Length;

            Array.Sort(innerCollection, 0, size, comparison);
            //BubbleSort(innerCollection, comparison);
            //SelectionSort(innerCollection, comparison);
            //InsertionSort(innerCollection, comparison);
            //QuickSort(innerCollection, comparison, 0, Size - 1);
        }

        private void Resize()
        {
            T[] newCollection = new T[Size * 2];
            Array.Copy(innerCollection, newCollection, Size);
            innerCollection = newCollection;
        }

        public void AddAll(ICollection<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }

            if (Size + collection.Count >= innerCollection.Length)
            {
                MultiResize(collection);
            }

            foreach (T element in collection)
            {
                innerCollection[Size] = element;
                size++;
            }

            innerCollection = innerCollection.Where(x => x != null).ToArray();
            size = innerCollection.Length;

            Array.Sort(innerCollection, 0, size, comparison);
            //BubbleSort(innerCollection, comparison);
            //SelectionSort(innerCollection, comparison);
            //InsertionSort(innerCollection, comparison);
            //QuickSort(innerCollection, comparison, 0, Size - 1);
        }

        private void QuickSort(T[] collection, IComparer<T> comparer, int lowest, int highest)
        {
            if (lowest < highest)
            {
                int part = partition(collection, comparer, lowest, highest);
                QuickSort(collection, comparer, lowest, part - 1);
                QuickSort(collection, comparer, part + 1, highest);
            }
        }

        private int partition(T[] collection, IComparer<T> comparer, int lowest, int highest)
        {
            T pivot = collection[highest];

            int i = lowest - 1;

            for (int j = lowest; j <= highest - 1; j++)
            {
                if (comparer.Compare(collection[j], pivot) < 1)
                {
                    i++;
                    T temp = collection[j];
                    collection[j] = collection[i];
                    collection[i] = temp;
                }
            }

            T temp2 = collection[i + 1];
            collection[i + 1] = collection[highest];
            collection[highest] = temp2;

            return (i + 1); 
        }

        private void InsertionSort(T[] collection, IComparer<T> comparer)
        {
            for (int i = 1; i < collection.Length; i++)
            {
                T key = collection[i];
                int j = i - 1;

                while (comparer.Compare(key, collection[j]) < 1 && j >= 0)
                {
                    collection[j + 1] = collection[j];
                    --j;

                    if (j < 0)
                    {
                        break;
                    }
                }

                collection[j + 1] = key;
            }
        }

        private void SelectionSort(T[] collection, IComparer<T> comparer)
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                int jMin = i;

                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (comparer.Compare(collection[j], collection[jMin]) < 1)
                    {
                        jMin = j;
                    }
                }

                if (jMin != i)
                {
                    T temp = collection[i];
                    collection[i] = collection[jMin];
                    collection[jMin] = temp;
                }
            }
        }

        private void BubbleSort(T[] collection, IComparer<T> comparer)
        {
            int n = collection.Length;

            do
            {
                int newn = 0;
                for (int i = 1; i <= n - 1; i++)
                {
                    if (comparer.Compare(collection[i - 1], collection[i]) > 0)
                    {
                        T temp = collection[i];
                        collection[i] = collection[i - 1];
                        collection[i - 1] = temp;
                        newn = i;
                    }
                }
                n = newn;
            } while (n > 1);
        }

        private void MultiResize(ICollection<T> collection)
        {
            int newSize = innerCollection.Length * 2;

            while (Size + collection.Count >= newSize)
            {
                newSize *= 2;
            }

            T[] newCollection = new T[newSize];
            Array.Copy (innerCollection, newCollection, size);
            innerCollection = newCollection;
        }

        public string JoinWith(string joiner)
        {
            if (joiner == null)
            {
                throw new ArgumentNullException();
            }

            StringBuilder builder = new StringBuilder();

            foreach (var element in this)
            {
                builder.Append(element);
                builder.Append(joiner);
            }

            builder.Remove(builder.Length - joiner.Length, joiner.Length);
            return builder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Size; i++)
            {
                yield return innerCollection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
