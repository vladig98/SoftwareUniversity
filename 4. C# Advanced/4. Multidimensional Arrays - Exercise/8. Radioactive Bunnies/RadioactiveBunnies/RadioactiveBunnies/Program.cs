using System;
using System.Linq;

namespace RadioactiveBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                string[] tokens = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = tokens[k]; 
                }
            }

            string[] commands = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();
            int playerLastX = -1;
            int playerLastY = -1;
            bool gameOver = false;
            bool isAlive = false;
            bool toBreak = false;

            for (int k = 0; k < commands.Length; k++)
            {
                toBreak = false;
                if (commands[k] == "U")
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] == "P")
                            {
                                if (i - 1 >= 0)
                                {
                                    if (matrix[i - 1, j] == "B")
                                    {
                                        gameOver = true;
                                        playerLastX = i - 1;
                                        playerLastY = j;
                                        matrix[i, j] = ".";
                                    }
                                    else
                                    {
                                        matrix[i - 1, j] = "P";
                                        matrix[i, j] = ".";
                                    }
                                }
                                else
                                {
                                    playerLastX = i;
                                    playerLastY = j;
                                    matrix[i, j] = ".";
                                    isAlive = true;
                                    gameOver = true;
                                }
                                toBreak = true;
                                break;
                            }
                        }
                        if (toBreak)
                        {
                            break;
                        }
                    }
                }
                else if (commands[k] == "D")
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] == "P")
                            {
                                if (i + 1 < matrix.GetLength(0))
                                {
                                    if (matrix[i + 1, j] == "B")
                                    {
                                        gameOver = true;
                                        playerLastX = i + 1;
                                        playerLastY = j;
                                        matrix[i, j] = ".";
                                    }
                                    else
                                    {
                                        matrix[i + 1, j] = "P";
                                        matrix[i, j] = ".";
                                    }
                                }
                                else
                                {
                                    playerLastX = i;
                                    playerLastY = j;
                                    matrix[i, j] = ".";
                                    isAlive = true;
                                    gameOver = true;
                                }
                                toBreak = true;
                                break;
                            }
                        }
                        if (toBreak)
                        {
                            break;
                        }
                    }
                }
                else if (commands[k] == "L")
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] == "P")
                            {
                                if (j - 1 >= 0)
                                {
                                    if (matrix[i, j - 1] == "B")
                                    {
                                        gameOver = true;
                                        playerLastX = i;
                                        playerLastY = j - 1;
                                        matrix[i, j] = ".";
                                    }
                                    else
                                    {
                                        matrix[i, j - 1] = "P";
                                        matrix[i, j] = ".";
                                    }  
                                }
                                else
                                {
                                    playerLastX = i;
                                    playerLastY = j;
                                    matrix[i, j] = ".";
                                    isAlive = true;
                                    gameOver = true;
                                }
                                toBreak = true;
                                break;
                            }
                        }
                        if (toBreak)
                        {
                            break;
                        }
                    }
                }
                else if (commands[k] == "R")
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] == "P")
                            {
                                if (j + 1 < matrix.GetLength(1))
                                {
                                    if (matrix[i, j + 1] == "B")
                                    {
                                        gameOver = true;
                                        playerLastX = i;
                                        playerLastY = j + 1;
                                        matrix[i, j] = ".";
                                    }
                                    else
                                    {
                                        matrix[i, j + 1] = "P";
                                        matrix[i, j] = ".";
                                    }
                                }
                                else
                                {
                                    playerLastX = i;
                                    playerLastY = j;
                                    matrix[i, j] = ".";
                                    isAlive = true;
                                    gameOver = true;
                                }
                                toBreak = true;
                                break;
                            }
                        }
                        if (toBreak)
                        {
                            break;
                        }
                    }
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int neigbourIndex1 = j - 1;
                        int neigbourIndex2 = i - 1;
                        int neigbourIndex3 = i + 1;
                        int neigbourIndex4 = j + 1;

                        if (matrix[i, j] == "B")
                        {
                            if (neigbourIndex1 >= 0)
                            {
                                if (matrix[i, neigbourIndex1] == "P")
                                {
                                    gameOver = true;
                                    playerLastX = i;
                                    playerLastY = neigbourIndex1;
                                }

                                if (matrix[i, neigbourIndex1] != "B")
                                {
                                    matrix[i, neigbourIndex1] = "b";
                                }
                            }
                            if (neigbourIndex2 >= 0)
                            {
                                if (matrix[neigbourIndex2, j] == "P")
                                {
                                    gameOver = true;
                                    playerLastX = neigbourIndex2;
                                    playerLastY = j;
                                }
                                
                                if (matrix[neigbourIndex2, j] != "B")
                                {
                                    matrix[neigbourIndex2, j] = "b";
                                }
                            }

                            if (neigbourIndex3 < matrix.GetLength(0))
                            {
                                if (matrix[neigbourIndex3, j] == "P")
                                {
                                    gameOver = true;
                                    playerLastX = neigbourIndex3;
                                    playerLastY = j;
                                }
                               
                                if (matrix[neigbourIndex3, j] != "B")
                                {
                                    matrix[neigbourIndex3, j] = "b";
                                }
                            }

                            if (neigbourIndex4 < matrix.GetLength(1))
                            {
                                if (matrix[i, neigbourIndex4] == "P")
                                {
                                    gameOver = true;
                                    playerLastX = i;
                                    playerLastY = neigbourIndex4;
                                }
                                
                                if (matrix[i, neigbourIndex4] != "B")
                                {
                                    matrix[i, neigbourIndex4] = "b";
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == "b")
                        {
                            matrix[i, j] = "B";
                        }
                    }
                }

                if (gameOver == true)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();
                    }

                    if (isAlive == true)
                    {
                        Console.WriteLine("won: {0} {1}", playerLastX, playerLastY);
                    }
                    else
                    {
                        Console.WriteLine("dead: {0} {1}", playerLastX, playerLastY);
                    }

                    return;
                }
            }
        }
    }
}
