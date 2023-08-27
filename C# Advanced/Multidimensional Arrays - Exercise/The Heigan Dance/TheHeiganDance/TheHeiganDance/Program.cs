using System;
using System.Linq;

namespace TheHeiganDance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[15, 15];

            double playerHealth = 18500;
            double heiganHelth = 3000000;

            int playerX = 7;
            int playerY = 7;

            double cloudDamage = 3500;
            double erruptionDamage = 6000;

            double playerAttackDamage = double.Parse(Console.ReadLine());

            bool gameOver = false;
            bool cloudDamageActivated = false;
            bool isPlayerAlive = true;
            bool isHaiganAlive = true;
            string finalSpell = string.Empty;

            while (!gameOver)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();

                if (gameOver)
                {
                    break;
                }

                if (tokens.Length == 1)
                {
                    break;
                }

                if (!gameOver)
                {
                    heiganHelth -= playerAttackDamage;
                }

                if (cloudDamageActivated)
                {
                    playerHealth -= cloudDamage;
                    cloudDamageActivated = false;

                    if (playerHealth <= 0)
                    {
                        gameOver = true;
                        isPlayerAlive = false;
                        finalSpell = "Plague Cloud";
                    }
                }

                if (heiganHelth <= 0)
                {
                    gameOver = true;
                    isHaiganAlive = false;
                }

                int spellX = int.Parse(tokens[1]);
                int spellY = int.Parse(tokens[2]);

                if (gameOver)
                {
                    break;
                }

                for (int i = spellX - 1; i <= spellX + 1; i++)
                {
                    for (int j = spellY - 1; j <= spellY + 1; j++)
                    {
                        if (i == playerX && j == playerY)
                        {
                            if (playerX - 1 >= 0 && playerX - 1 < spellX - 1)
                            {
                                playerX--;
                            }
                            else if (playerY + 1 <= matrix.GetLength(0) && playerY + 1 > spellY + 1)
                            {
                                playerY++;
                            }
                            else if (playerX + 1 <= matrix.GetLength(0) && playerX + 1 > spellX + 1)
                            {
                                playerX++;
                            }
                            else if (playerY - 1 >= 0 && playerY - 1 < spellY - 1)
                            {
                                playerY--;
                            }
                            else
                            {
                                if (tokens[0] == "Cloud")
                                {
                                    playerHealth -= cloudDamage;
                                    cloudDamageActivated = true;
                                    if (playerHealth <= 0)
                                    {
                                        gameOver = true;
                                        isPlayerAlive = false;
                                        finalSpell = "Plague Cloud";
                                    }
                                }
                                else if (tokens[0] == "Eruption")
                                {
                                    playerHealth -= erruptionDamage;

                                    if (playerHealth <= 0)
                                    {
                                        gameOver = true;
                                        isPlayerAlive = false;
                                        finalSpell = "Eruption";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!isPlayerAlive && !isHaiganAlive)
            {
                Console.WriteLine("Heigan: Defeated!");
                Console.WriteLine("Player: Killed by {0}", finalSpell);
                Console.WriteLine("Final position: {0}, {1}", playerX, playerY);
            }
            else if (isPlayerAlive)
            {
                Console.WriteLine("Heigan: Defeated!");
                Console.WriteLine("Player: {0}", playerHealth);
                Console.WriteLine("Final position: {0}, {1}", playerX, playerY);
            }
            else
            {
                Console.WriteLine("Heigan: {0:F2}", heiganHelth);
                Console.WriteLine("Player: Killed by {0}", finalSpell);
                Console.WriteLine("Final position: {0}, {1}", playerX, playerY);
            }
        }
    }
}
