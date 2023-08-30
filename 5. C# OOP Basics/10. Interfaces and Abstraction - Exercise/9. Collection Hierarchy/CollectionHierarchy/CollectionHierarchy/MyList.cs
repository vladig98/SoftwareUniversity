using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IAdd, IRemove
    {
        private List<object> Items { get; set; }
        private int used;

        public int Used
        {
            get
            {
                return used;
            }
            private set
            {
                used = value;
            }
        }
        
        public int Add(object item)
        {
            Items.Insert(0, item);
            UpdateCount();
            return 0;
        }

        public object Remove()
        {
            var item = Items.First();
            Items.Remove(item);
            UpdateCount();
            return item;
        }

        private void UpdateCount()
        {
            Used = Items.Count;
        }

        public MyList()
        {
            Items = new List<object>();
        }
    }
}
