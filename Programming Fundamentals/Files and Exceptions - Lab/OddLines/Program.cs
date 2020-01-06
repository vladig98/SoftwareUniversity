using System;
using System.IO;
using System.Linq;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\..\input.txt");
            lines = lines.Where((x, i) => i % 2 != 0).ToArray();
            File.AppendAllLines(@"..\..\..\output.txt", lines);
        }
    }
}
