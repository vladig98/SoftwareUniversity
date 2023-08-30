using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\..\input.txt");
            lines = lines.Select((x, i) => string.Format($"{(i + 1)}. {x}")).ToArray();
            File.WriteAllLines(@"..\..\..\output.txt", lines);
        }
    }
}
