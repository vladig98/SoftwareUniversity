using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MinionORM
{
    public class DbSet<TEntity> : ICollection<TEntity> where TEntity : class, new()
    {
        internal ChangeTracker<TEntity> ChangeTracker { get; set;}
        internal IList<TEntity> Entities { get; set;}

        public int Count => Entities.Count;

        public bool IsReadOnly => Entities.IsReadOnly;

        internal DbSet(IEnumerable<TEntity> entities)
        {
            Entities = entities.ToList();
            ChangeTracker = new ChangeTracker<TEntity>(entities);
        }

        public void Add(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null!");
            }

            Entities.Add(item);
            ChangeTracker.Add(item);
        }

        public void Clear()
        {
            while (Entities.Any())
            {
                TEntity entity = Entities.First();
                Remove(entity);
            }
        }

        public bool Contains(TEntity item)
        {
            return Entities.Contains(item);
        }

        public void CopyTo(TEntity[] array, int arrayIndex)
        {
            Entities.CopyTo(array, arrayIndex);
        }

        public bool Remove(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null!");
            }

            bool removedSuccessfully = Entities.Remove(item);

            if (removedSuccessfully)
            {
                ChangeTracker.Remove(item);
            }

            return removedSuccessfully;
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return Entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities.ToArray())
            {
                Remove(entity);
            }
        }
    }
}
