using System;
using System.Linq;

namespace LegoBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray1 = new int[rows][];
            int[][] jaggedArray2 = new int[rows][];
            int[][] jaggedArrayCombined = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArray1[i] = numbers;
            }

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArray2[i] = numbers;
            }

            for (int i = 0; i < rows; i++)
            {
                jaggedArray2[i] = jaggedArray2[i].Reverse().Select(x => x).ToArray();
            }

            for (int i = 0; i < rows; i++)
            {
                jaggedArrayCombined[i] = jaggedArray1[i].Concat(jaggedArray2[i]).ToArray();
            }

            bool allEqual = true;

            for (int i = 0; i < rows - 1; i++)
            {
                if (jaggedArrayCombined[i].Length != jaggedArrayCombined[i + 1].Length)
                {
                    allEqual = false;
                }
            }

            if (allEqual == true)
            {
                for (int i = 0; i < jaggedArrayCombined.Length; i++)
                {
                    Console.WriteLine("[{0}]", string.Join(", ", jaggedArrayCombined[i]));
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: {0}", jaggedArrayCombined.Sum(x => x.Length));
            }
        }
    }
}
