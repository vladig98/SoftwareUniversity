using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');
            int numberOfRemoveOperations = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection removeCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            List<object> addCollectionAddIndecies = new List<object>();
            List<object> addRemoveCollectionAddIndecies = new List<object>();
            List<object> myListAddIndecies = new List<object>();
            List<object> addRemoveCollectionRemoveObjects = new List<object>();
            List<object> myListRemoveObjects = new List<object>();

            foreach (var element in elements)
            {
                addCollectionAddIndecies.Add(addCollection.Add(element));
                addRemoveCollectionAddIndecies.Add(removeCollection.Add(element));
                myListAddIndecies.Add(myList.Add(element));
            }

            for (int i = 0; i < numberOfRemoveOperations; i++)
            {
                addRemoveCollectionRemoveObjects.Add(removeCollection.Remove());
                myListRemoveObjects.Add(myList.Remove());
            }

            Console.WriteLine(string.Join(" ", addCollectionAddIndecies));
            Console.WriteLine(string.Join(" ", addRemoveCollectionAddIndecies));
            Console.WriteLine(string.Join(" ", myListAddIndecies));
            Console.WriteLine(string.Join(" ", addRemoveCollectionRemoveObjects));
            Console.WriteLine(string.Join(" ", myListRemoveObjects));
        }
    }
}
