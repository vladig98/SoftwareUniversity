using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            int index = 0;

            using (reader)
            {
                string input = reader.ReadLine();

                while (input != null)
                {
                    if (index % 2 != 0)
                    {
                        using (writer)
                        {
                            writer.WriteLine(input);
                        }
                    }

                    index++;
                    input = reader.ReadLine();
                }
            }
        }
    }
}
