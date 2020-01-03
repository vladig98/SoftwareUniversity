using System;
using System.IO;
using System.Linq;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Vladi\source\repos\Software University\SoftwareUniversity\Programming Fundamentals\Files and Exceptions - Lab\OddLines\input.txt");
            lines = lines.Where((x, i) => i % 2 != 0).ToArray();
            File.AppendAllLines(@"C:\Users\Vladi\source\repos\Software University\SoftwareUniversity\Programming Fundamentals\Files and Exceptions - Lab\OddLines\output.txt", lines);
        }
    }
}
