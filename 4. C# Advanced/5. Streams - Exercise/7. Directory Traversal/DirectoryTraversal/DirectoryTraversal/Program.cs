using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> files = new Dictionary<string, List<string>>();

            string[] filesFromDirectory = Directory.GetFiles(@"");

            foreach (var file in filesFromDirectory)
            {
                string fileName = string.Join("\\", file.Split("\\").Take(file.Split("\\").Length - 1)) + "\\" + file.Split("\\")[file.Split("\\").Length - 1].Split(".")[0];
                string fileExtension = string.Join(".", file.Split("\\")[file.Split("\\").Length - 1].Split(".").Skip(1));

                if (files.ContainsKey(fileExtension))
                {
                    files[fileExtension].Add(fileName);
                }
                else
                {
                    files.Add(fileExtension, new List<string> { fileName });
                }
            }

            files = files.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value.OrderBy(x => x).ToList());

            StreamWriter writer = new StreamWriter("report.txt");

            foreach (var file in files)
            {
                writer.WriteLine("." + file.Key);

                foreach (var value in file.Value)
                {
                    FileInfo fileInfo = new FileInfo(value + "." + file.Key);
                    writer.WriteLine("--{0}.{1} - {2:F3} kb", value.Split("\\")[value.Split("\\").Length - 1], file.Key, (double)(fileInfo.Length / 1024.0));
                }
            }

            writer.Close();
        }
    }
}
