﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }

        public Cat(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }
    }
}
