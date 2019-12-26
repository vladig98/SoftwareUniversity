using System;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int mastchSum = int.Parse(Console.ReadLine());
            int sum = 0;
            char beginningAndEnding = ' ';

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    for (int k = 1; k < 5; k++)
                    {
                        sum = i + j + k;
                        if (sum >= mastchSum)
                        {
                            beginningAndEnding = 'O';
                        }
                        else
                        {
                            beginningAndEnding = 'X';
                        }

                        Console.Write("{0}{1}{2}{3}{0} ", beginningAndEnding, (Letter)i, (Letter)j, (Letter)k);
                    }
                    Console.WriteLine();
                }
            }
        }

        public enum Letter
        {
            A = 1,
            C = 2,
            G = 3,
            T = 4
        }
    }
}
