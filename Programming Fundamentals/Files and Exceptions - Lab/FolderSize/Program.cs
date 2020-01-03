using System;
using System.IO;
using System.Linq;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Vladi\source\repos\Software University\SoftwareUniversity\Programming Fundamentals\Files and Exceptions - Lab\FolderSize\TestFolder";
            string[] files = Directory.GetFiles(path, "*.*");
            long bytes = files.Select(x => new FileInfo(x).Length).Sum();
            decimal megabytes = (bytes / 1024M) / 1024M;
            File.WriteAllText(path + @"\..\output.txt", megabytes.ToString());
        }
    }
}
