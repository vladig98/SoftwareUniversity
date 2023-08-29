using System;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int boat1Moves = 0;
            int boat2Moves = 0;

            for (int i = 0; i < number; i++)
            {
                string command = Console.ReadLine();
                if (i % 2 == 0)
                {
                    if (command == "UPGRADE")
                    {
                        boat1 = (char)(boat1 + 3);
                        boat2 = (char)(boat2 + 3);
                    }
                    else
                    {
                        boat1Moves += command.Length;
                        if (boat1Moves >= 50)
                        {
                            Console.WriteLine(boat1);
                            return;
                        }
                    }
                }
                else
                {
                    if (command == "UPGRADE")
                    {
                        boat1 = (char)(boat1 + 3);
                        boat2 = (char)(boat2 + 3);
                    }
                    else
                    {
                        boat2Moves += command.Length;
                        if (boat2Moves >= 50)
                        {
                            Console.WriteLine(boat2);
                            return;
                        }
                    }
                }
            }

            if (boat1Moves > boat2Moves)
            {
                Console.WriteLine(boat1);
            }
            else if (boat2Moves > boat1Moves)
            {
                Console.WriteLine(boat2);
            }
        }
    }
}
