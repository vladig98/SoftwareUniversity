using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong length = ulong.Parse(Console.ReadLine());

            ulong[][] triangle = new ulong[length][];

            triangle[0] = new ulong[] { 1 };

            for (int i = 1; i < triangle.Length; i++)
            {
                triangle[i] = new ulong[i + 1];
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    ulong value = 0;

                    int row = i - 1;
                    int col = j;
                    int col2 = j - 1;

                    if (row < 0 || col >= triangle[row].Length)
                    {
                        if (row < 0 || col2 < 0)
                        {
                            value += 0;
                        }
                        else
                        {
                            value += 0 + triangle[row][col2];
                        }
                        
                    }
                    else if (row < 0 || col2 < 0)
                    {
                        value += triangle[row][col] + 0;
                    }
                    else
                    {
                        value += triangle[row][col] + triangle[row][col2];
                    }

                    triangle[i][j] = value;
                }
            }

            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
