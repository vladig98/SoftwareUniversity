using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAdd, IRemove
    {
        private List<object> Items { get; set; }

        public int Add(object item)
        {
            Items.Insert(0, item);
            return 0;
        }

        public object Remove()
        {
            var item = Items.ElementAt(Items.Count - 1);
            Items.RemoveAt(Items.Count - 1);
            return item;
        }

        public AddRemoveCollection()
        {
            Items = new List<object>();
        }
    }
}
