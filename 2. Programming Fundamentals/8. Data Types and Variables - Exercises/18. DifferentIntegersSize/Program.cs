using System;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = $"{number} can fit in:\r\n";
            bool canFit = false;

            try
            {
                sbyte number2 = sbyte.Parse(number);
                result += "* sbyte\r\n";
                canFit = true;
            }
            catch (Exception)
            {
            }

            try
            {
                byte number2 = byte.Parse(number);
                result += "* byte\r\n";
                canFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                short number2 = short.Parse(number);
                result += "* short\r\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            try
            {
                ushort number2 = ushort.Parse(number);
                result += "* ushort\r\n";
                canFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                int number2 = int.Parse(number);
                result += "* int\r\n";
                canFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                uint number2 = uint.Parse(number);
                result += "* uint\r\n";
                canFit = true;
            }
            catch (Exception)
            {
               
            }

            try
            {
                long number2 = long.Parse(number);
                result += "* long\r\n";
                canFit = true;
            }
            catch (Exception)
            {
                
            }

            if (!canFit)
            {
                Console.WriteLine($"{number} can't fit in any type");
                return;
            }

            Console.WriteLine(result);
        }
    }
}
