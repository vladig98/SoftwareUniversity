using System;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Pizza pizza = null;

            while (input != "END")
            {
                string[] inputTokens = input.Split(' ');

                if (inputTokens[0] == "Dough")
                {
                    try
                    {
                        Dough dough = new Dough(inputTokens[1], inputTokens[2], double.Parse(inputTokens[3]));

                        pizza.Dough = dough;
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
                else if (inputTokens[0] == "Topping")
                {
                    try
                    {
                        Topping topping = new Topping(inputTokens[1], double.Parse(inputTokens[2]));

                        pizza.AddTopping(topping);
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
                else
                {
                    try
                    {
                        pizza = new Pizza(inputTokens[1]);
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(pizza.ToString());
        }
    }
}
