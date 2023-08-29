using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            const int studioMayAndOctober = 50;
            const int studioJuneAndSeptember = 60;
            const int studioJulyAndAugustAndDecember = 68;
            
            const int doubleMayAndOctober = 65;
            const int doubleJuneAndSeptember = 72;
            const int doubleJulyAndAugustAndDecember = 77;
            
            const int suiteMayAndOctober = 75;
            const int suiteJuneAndSeptember = 82;
            const int suiteJulyAndAugustAndDecember = 89;

            const double studioMoreThan7DaysInMayAndOctoberDiscount = 0.95;
            const double doubleMoreThan14DaysInJuneAndSeptemberDiscount = 0.9;
            const double suiteMoreThan14DaysInJulyAndAugustAndDecemberDiscount = 0.85;

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            switch (month.ToLower())
            {
                case "may":
                case "october":
                    studioPrice = studioMayAndOctober * nights;
                    doublePrice = doubleMayAndOctober * nights;
                    suitePrice = suiteMayAndOctober * nights;
                    if (nights > 7)
                    {
                        if (month.ToLower() == "october")
                        {
                            studioPrice -= studioMayAndOctober;
                        }
                        studioPrice *= studioMoreThan7DaysInMayAndOctoberDiscount;
                    }
                    break;
                case "june":
                case "september":
                    studioPrice = studioJuneAndSeptember * nights;
                    doublePrice = doubleJuneAndSeptember * nights;
                    suitePrice = suiteJuneAndSeptember * nights;
                    if (nights > 7)
                    {
                        if (month.ToLower() == "september")
                        {
                            studioPrice -= studioJuneAndSeptember;
                        }
                    }
                    if (nights > 14)
                    {
                        doublePrice *= doubleMoreThan14DaysInJuneAndSeptemberDiscount;
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    studioPrice = studioJulyAndAugustAndDecember * nights;
                    doublePrice = doubleJulyAndAugustAndDecember * nights;
                    suitePrice = suiteJulyAndAugustAndDecember * nights;
                    if (nights > 14)
                    {
                        suitePrice *= suiteMoreThan14DaysInJulyAndAugustAndDecemberDiscount;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Studio: {studioPrice.ToString("F2")} lv.");
            Console.WriteLine($"Double: {doublePrice.ToString("F2")} lv.");
            Console.WriteLine($"Suite: {suitePrice.ToString("F2")} lv.");
        }
    }
}
