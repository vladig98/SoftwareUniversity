﻿using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code to debug and fix


            //string text = Console.ReadLine();
            //int jump = int.Parse(Console.ReadLine());

            //const char Search = 'р';
            //bool hasMatch = false;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == Search)
            //    {
            //        hasMatch = true;

            //        int endIndex = jump;

            //        if (endIndex > text.Length)
            //        {
            //            endIndex = text.Length;
            //        }

            //        string matchedString = text.Substring(i, endIndex);
            //        Console.WriteLine(matchedString);
            //        i += jump;
            //    }
            //}

            //if (!hasMatch)
            //{
            //    Console.WriteLine("no");
            //}

            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump + 1;

                    if (endIndex + i >= text.Length)
                    {
                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
