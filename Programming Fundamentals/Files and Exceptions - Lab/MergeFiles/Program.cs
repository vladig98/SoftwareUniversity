using System;
using System.Collections.Generic;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";
            string[] fileOne = File.ReadAllLines(path + "FileOne.txt");
            string[] fileTwo = File.ReadAllLines(path + "FileTwo.txt");
            List<string> result = new List<string>();

            for (int i = 0; i < fileOne.Length; i++)
            {
                result.Add(fileOne[i]);
                result.Add(fileTwo[i]);
            }

            File.WriteAllLines(path + "output.txt", result);
        }
    }
}
