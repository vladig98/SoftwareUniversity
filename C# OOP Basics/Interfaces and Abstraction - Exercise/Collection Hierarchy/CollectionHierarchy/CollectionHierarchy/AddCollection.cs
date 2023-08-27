using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAdd
    {
        private List<object> Items { get; set; }

        public int Add(object item)
        {
            Items.Add(item);
            return Items.Count - 1;
        }

        public AddCollection()
        {
            Items = new List<object>();
        }
    }
}
