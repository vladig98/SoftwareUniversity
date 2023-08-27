using System;
using System.Collections.Generic;
using System.Text;

namespace CatLady
{
    public class Siamese : Cat
    {
        public int EarSize { get; set; }

        public Siamese(string name, int earSize)
        {
            Name = name;
            EarSize = earSize;
            Type = "Siamese";
        }
    }
}
