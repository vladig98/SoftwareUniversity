using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int caloriesCheese = 500;
            const int caloriesTomatoSauce = 150;
            const int caloriesSalami = 600;
            const int caloriesPepper = 50;

            int number = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < number; i++)
            {
                string ingredient = Console.ReadLine();
                switch (ingredient.ToLower())
                {
                    case "cheese":
                        totalCalories += caloriesCheese;
                        break;
                    case "tomato sauce":
                        totalCalories += caloriesTomatoSauce;
                        break;
                    case "salami":
                        totalCalories += caloriesSalami;
                        break;
                    case "pepper":
                        totalCalories += caloriesPepper;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
