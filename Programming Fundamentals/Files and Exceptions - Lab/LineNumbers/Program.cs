using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Vladi\source\repos\Software University\SoftwareUniversity\Programming Fundamentals\Files and Exceptions - Lab\LineNumbers\input.txt");
            lines = lines.Select((x, i) => string.Format($"{(i + 1)}. {x}")).ToArray();
            File.WriteAllLines(@"C:\Users\Vladi\source\repos\Software University\SoftwareUniversity\Programming Fundamentals\Files and Exceptions - Lab\LineNumbers\output.txt", lines);
        }
    }
}
