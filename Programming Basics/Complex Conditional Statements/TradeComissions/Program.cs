using System;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            const double comissionBetween0and500inSofia = 5;
            const double comissionBetween0and500inVarna = 4.5;
            const double comissionBetween0and500inPlovdiv = 5.5;
            
            const double comissionBetween500and1000inSofia = 7;
            const double comissionBetween500and1000inVarna = 7.5;
            const double comissionBetween500and1000inPlovdiv = 8;
            
            const double comissionBetween1000and10000inSofia = 8;
            const double comissionBetween1000and10000inVarna = 10;
            const double comissionBetween1000and10000inPlovdiv = 12;
            
            const double comissionOver10000inSofia = 12;
            const double comissionOver10000inVarna = 13;
            const double comissionOver10000inPlovdiv = 14.5;

            string city = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());

            switch (city)
            {
                case "Sofia":
                    if (money >= 0 && money <= 500)
                    {
                        Console.WriteLine(money * comissionBetween0and500inSofia / 100);
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        Console.WriteLine(money * comissionBetween500and1000inSofia / 100);
                    }
                    else if (money > 1000 && money <= 10_000)
                    {
                        Console.WriteLine(money * comissionBetween1000and10000inSofia / 100);
                    }
                    else if (money > 10_000)
                    {
                        Console.WriteLine(money * comissionOver10000inSofia / 100);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (money >= 0 && money <= 500)
                    {
                        Console.WriteLine(money * comissionBetween0and500inPlovdiv / 100);
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        Console.WriteLine(money * comissionBetween500and1000inPlovdiv / 100);
                    }
                    else if (money > 1000 && money <= 10_000)
                    {
                        Console.WriteLine(money * comissionBetween1000and10000inPlovdiv / 100);
                    }
                    else if (money > 10_000)
                    {
                        Console.WriteLine(money * comissionOver10000inPlovdiv / 100);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (money >= 0 && money <= 500)
                    {
                        Console.WriteLine(money * comissionBetween0and500inVarna / 100);
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        Console.WriteLine(money * comissionBetween500and1000inVarna / 100);
                    }
                    else if (money > 1000 && money <= 10_000)
                    {
                        Console.WriteLine(money * comissionBetween1000and10000inVarna / 100);
                    }
                    else if (money > 10_000)
                    {
                        Console.WriteLine(money * comissionOver10000inVarna / 100);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
