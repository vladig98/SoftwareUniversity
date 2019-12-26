using System;

namespace CatchtheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            long maxValue = long.MinValue;

            for (int i = 0; i < number; i++)
            {
                switch (type)
                {
                    case "sbyte":
                        try
                        {
                            sbyte temp = sbyte.Parse(Console.ReadLine());
                            if (temp > maxValue && temp <= sbyte.MaxValue)
                            {
                                maxValue = temp;
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case "int":
                        try
                        {
                            int temp2 = int.Parse(Console.ReadLine());
                            if (temp2 > maxValue && temp2 <= int.MaxValue)
                            {
                                maxValue = temp2;
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case "long":
                        try
                        {
                            long temp3 = long.Parse(Console.ReadLine());
                            if (temp3 > maxValue && temp3 <= long.MaxValue)
                            {
                                maxValue = temp3;
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
