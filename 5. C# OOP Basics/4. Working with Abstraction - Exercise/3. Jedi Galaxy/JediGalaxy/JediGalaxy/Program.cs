﻿using System;
using System.Linq;

namespace JediGalaxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //int x = dimestions[0];
            //int y = dimestions[1];

            //int[,] matrix = new int[x, y];

            //int value = 0;
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        matrix[i, j] = value++;
            //    }
            //}

            //string command = Console.ReadLine();
            //long sum = 0;
            //while (command != "Let the Force be with you")
            //{
            //    int[] ivoS = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //    int[] evil = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //    int xE = evil[0];
            //    int yE = evil[1];

            //    while (xE >= 0 && yE >= 0)
            //    {
            //        if (xE >= 0 && xE < matrix.GetLength(0) && yE >= 0 && yE < matrix.GetLength(1))
            //        {
            //            matrix[xE, yE] = 0;
            //        }
            //        xE--;
            //        yE--;
            //    }

            //    int xI = ivoS[0];
            //    int yI = ivoS[1];

            //    while (xI >= 0 && yI < matrix.GetLength(1))
            //    {
            //        if (xI >= 0 && xI < matrix.GetLength(0) && yI >= 0 && yI < matrix.GetLength(1))
            //        {
            //            sum += matrix[xI, yI];
            //        }

            //        yI++;
            //        xI--;
            //    }

            //    command = Console.ReadLine();
            //}

            //Console.WriteLine(sum);
            const string end = "Let the Force be with you";

            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int x = dimestions[0];
            int y = dimestions[1];

            int[,] matrix = new int[x, y];

            FillMatrix(matrix);

            string command = Console.ReadLine();

            long sum = 0;

            while (command != end)
            {
                int[] ivoS = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evil = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                DestroyStars(evil, matrix);
                sum += GatherStars(ivoS, matrix);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }

        private static long GatherStars(int[] ivoS, int[,] matrix)
        {
            long sum = 0;

            int xI = ivoS[0];
            int yI = ivoS[1];

            while (xI >= 0 && yI < matrix.GetLength(1))
            {
                if (xI >= 0 && xI < matrix.GetLength(0) && yI >= 0 && yI < matrix.GetLength(1))
                {
                    sum += matrix[xI, yI];
                }

                yI++;
                xI--;
            }

            return sum;
        }

        private static void DestroyStars(int[] evil, int[,] matrix)
        {
            int xE = evil[0];
            int yE = evil[1];

            while (xE >= 0 && yE >= 0)
            {
                if (xE >= 0 && xE < matrix.GetLength(0) && yE >= 0 && yE < matrix.GetLength(1))
                {
                    matrix[xE, yE] = 0;
                }
                xE--;
                yE--;
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            int value = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }
    }
}
