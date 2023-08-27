using System;
using System.Collections.Generic;
using System.Text;

namespace CatLady
{
    public class StreetExtraordinaire : Cat
    {
        public int DecibelsOfMeows { get; set; }

        public StreetExtraordinaire(string name, int decibelsOfMeows)
        {
            Name = name;
            DecibelsOfMeows = decibelsOfMeows;
            Type = "StreetExtraordinaire";
        }
    }
}
