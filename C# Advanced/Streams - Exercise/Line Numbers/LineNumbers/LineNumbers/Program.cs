using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            int index = 1;

            using (reader)
            {
                string input = reader.ReadLine();

                using (writer)
                {
                    while (input != null)
                    {
                        writer.WriteLine("Line {0}: {1}", index, input);

                        index++;

                        input = reader.ReadLine();
                    }
                }
            }
        }
    }
}
