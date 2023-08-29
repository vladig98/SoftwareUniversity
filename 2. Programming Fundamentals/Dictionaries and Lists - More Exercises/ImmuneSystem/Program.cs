using System;
using System.Collections.Generic;
using System.Linq;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int imuneSystem = int.Parse(command);
            int maxStrenght = imuneSystem;

            List<string> viruses = new List<string>();

            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine($"Final Health: {imuneSystem}");
                    return;
                }
                viruses.Add(command);
                int strenght = command.ToCharArray().Sum(x => (int)x) / 3;
                int timeToDefeat = strenght * command.Length;
                timeToDefeat = viruses.Where(x => x == command).Count() >= 2 ? timeToDefeat / 3 : timeToDefeat;
                imuneSystem -= timeToDefeat;

                Console.WriteLine($"Virus {command}: {strenght} => {timeToDefeat} seconds");

                if (imuneSystem > 0)
                {
                    Console.WriteLine($"{command} defeated in {timeToDefeat / 60}m {timeToDefeat % 60}s.");
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                Console.WriteLine($"Remaining health: {imuneSystem}");

                imuneSystem += (int)(imuneSystem * 0.2);
                imuneSystem = imuneSystem > maxStrenght ? maxStrenght : imuneSystem;
            }
        }
    }
}
