using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal mm = 0.001M;
            const decimal cm = 0.01M;
            const decimal mi = 1609.344000614692M;
            const decimal inc = 0.025400000025908M;
            const decimal km = 1000M;
            const decimal ft = 0.304799999536704M;
            const decimal yd = 0.914399998610112M;

            decimal number = decimal.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            decimal converted = 0;

            if (from == "mm")
            {
                converted = number * mm;
            }

            if (from == "cm")
            {
                converted = number * cm;
            }

            if (from == "mi")
            {
                converted = number * mi;
            }

            if (from == "in")
            {
                converted = number * inc;
            }

            if (from == "km")
            {
                converted = number * km;
            }

            if (from == "ft")
            {
                converted = number * ft;
            }

            if (from == "yd")
            {
                converted = number * yd;
            }

            if (from == "m")
            {
                converted = number;
            }

            if (to == "mm")
            {
                Console.WriteLine(converted / mm);
            }

            if (to == "cm")
            {
                Console.WriteLine(converted / cm);
            }

            if (to == "mi")
            {
                Console.WriteLine(converted / mi);
            }

            if (to == "in")
            {
                Console.WriteLine(converted / inc);
            }

            if (to == "km")
            {
                Console.WriteLine(converted / km);
            }

            if (to == "ft")
            {
                Console.WriteLine(converted / ft);
            }

            if (to == "yd")
            {
                Console.WriteLine(converted / yd);
            }

            if (to == "m")
            {
                Console.WriteLine(converted);
            }
        }
    }
}
