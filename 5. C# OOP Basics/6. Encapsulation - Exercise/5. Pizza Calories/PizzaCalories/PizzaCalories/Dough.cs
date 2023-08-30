using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private FlourTypeEnum flourType;

        public string FlourType
        {
            get { return flourType.ToString(); }
            private set 
            {
                if (!Enum.TryParse(value.ToString().ToLower(), out FlourTypeEnum result))
                {
                    Console.WriteLine("Invalid type of dough.");
                    throw new Exception();
                }
                flourType = result; 
            }
        }

        private BakingTechniqueEnum bakingTechnique;

        public string BakingTechnique
        {
            get { return bakingTechnique.ToString(); }
            private set 
            {
                if (!Enum.TryParse(value.ToString().ToLower(), out BakingTechniqueEnum result))
                {
                    Console.WriteLine("Invalid type of dough.");
                    throw new Exception();
                }
                bakingTechnique = result; 
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 200)
                {
                    Console.WriteLine("Dough weight should be in the range [1...200].");
                    throw new Exception();
                }
                weight = value; 
            }
        }

        private double modifier { get; set; }

        private double calories;

        public double Calories
        {
            get { return calories; }
            private set { calories = value; }
        }

        public Dough(string flour, string technique, double weight)
        {
            FlourType = flour;
            BakingTechnique = technique;
            Weight = weight;
            modifier = 1.0;
            UpdateModifier();
            CalculateCalories();
        }

        private void CalculateCalories()
        {
            Calories = Weight * 2 * modifier;
        }

        private void UpdateModifier()
        {
            if (FlourType == FlourTypeEnum.wholegrain.ToString())
            {
                modifier *= 1.0;
            }
            else if (FlourType == FlourTypeEnum.white.ToString())
            {
                modifier *= 1.5;
            }

            if (BakingTechnique == BakingTechniqueEnum.crispy.ToString())
            {
                modifier *= 0.9;
            }
            else if (BakingTechnique == BakingTechniqueEnum.chewy.ToString())
            {
                modifier *= 1.1;
            }
            else if (BakingTechnique == BakingTechniqueEnum.homemade.ToString())
            {
                modifier *= 1.0;
            }
        }
    }
}
