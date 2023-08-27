using System;
using System.Collections.Generic;
using System.Text;

namespace CatLady
{
    public class Cymric : Cat
    {
        public double FurLength { get; set; }

        public Cymric(string name, double furLength)
        {
            Name = name;
            FurLength = furLength;
            Type = "Cymric";
        }
    }
}
