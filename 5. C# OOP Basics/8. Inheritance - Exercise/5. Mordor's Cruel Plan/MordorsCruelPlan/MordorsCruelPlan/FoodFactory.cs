using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan
{
    public class FoodFactory
    {
        //Returns points of happiness based on food
        public int GetPointsOfHappiness(string food)
        {
            switch (food.ToLower())
            {
                case "cram":
                    return 2;
                case "lembas":
                    return 3;
                case "apple":
                    return 1;
                case "melon":
                    return 1;
                case "honeycake":
                    return 5;
                case "mushrooms":
                    return -10;
                default:
                    return -1;
            }
        }
    }
}
