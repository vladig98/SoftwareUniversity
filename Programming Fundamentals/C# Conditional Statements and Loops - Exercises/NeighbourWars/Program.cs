using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            const int healthRestore = 10;
            const string peshoMove = "Roundhouse kick";
            const string goshoMove = "Thunderous fist";

            var attacker = Name.Pesho;
            var attacked = Name.Gosho;

            int round = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                if (attacker == Name.Pesho)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        goshoHealth = 0;
                    }
                    else
                    {
                        Console.WriteLine($"{attacker.ToString()} used {peshoMove} and reduced {attacked.ToString()} to {goshoHealth} health.");
                    }
                }
                else if (attacker == Name.Gosho)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        peshoHealth = 0;
                    }
                    else
                    {
                        Console.WriteLine($"{attacker.ToString()} used {goshoMove} and reduced {attacked.ToString()} to {peshoHealth} health.");
                    }
                }

                round++;

                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"{Name.Gosho.ToString()} won in {round}th round.");
                    return;
                }
                else if (goshoHealth <= 0)
                {
                    Console.WriteLine($"{Name.Pesho.ToString()} won in {round}th round.");
                    return;
                }

                if (round % 3 == 0)
                {
                    peshoHealth += healthRestore;
                    goshoHealth += healthRestore;
                }

                var temp = attacked;
                attacked = attacker;
                attacker = temp;
            }
        }

        public enum Name
        {
            Pesho,
            Gosho
        }
    }
}
