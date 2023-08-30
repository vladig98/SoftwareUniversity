using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            const string loopUntil = "END";
            const string dirIn = "IN";
            const string dirOut = "OUT";

            string input = Console.ReadLine();

            HashSet<string> parkingLot = new HashSet<string>();

            while (input != loopUntil)
            {
                string[] inputTokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = inputTokens[0];
                string regNumber = inputTokens[1];

                if (direction == dirIn)
                {
                    parkingLot.Add(regNumber);
                }
                else if (direction == dirOut)
                {
                    parkingLot.Remove(regNumber);
                }

                input = Console.ReadLine();
            }

            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
