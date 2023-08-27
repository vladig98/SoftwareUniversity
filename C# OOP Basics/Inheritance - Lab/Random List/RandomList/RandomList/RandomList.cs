using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;

        public object RandomString()
        {
            string str = null;
            if (this.Count > 0)
            {
                int index = rnd.Next(0, this.Count - 1);
                str = this[index];
                this.RemoveAt(index);
            }
            return str;
        }

        public RandomList()
        {
            rnd = new Random();
        }
    }
}
