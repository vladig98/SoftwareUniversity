using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SlicingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> files = new List<string>();

            files = Slice("sliceMe.mp4", @"", 5);
            
            Assemble(files, "assembled");
        }

        public static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
        {
            FileStream fileStream = new FileStream(destinationDirectory + "/" + sourceFile, FileMode.Open);

            byte[] readBytes = new byte[fileStream.Length];

            fileStream.Read(readBytes, 0, readBytes.Length);

            fileStream.Close();

            List<string> files = new List<string>();

            int partLength = readBytes.Length / parts;
            int beginning = 0;

            for (int i = 0; i < parts; i++)
            {
                string ext = Path.GetExtension(sourceFile);

                fileStream = new FileStream("part" + (i + 1) + ext, FileMode.Create);
                files.Add("part" + (i + 1) + ext);

                if (i == parts - 1)
                {
                    fileStream.Write(readBytes, beginning, readBytes.Length - ((parts - 1) * partLength));
                }
                else
                {
                    fileStream.Write(readBytes, beginning, partLength);
                }

                beginning += partLength;

                fileStream.Close();
            }

            return files;
        }

        public static void Assemble(List<string> files, string destinationDirectory)
        {
            List<byte[]> allBytes = new List<byte[]>();

            for (int i = 0; i < files.Count(); i++)
            {
                FileStream read = new FileStream(files.ElementAt(i), FileMode.Open);

                byte[] bytes = new byte[read.Length];

                read.Read(bytes, 0, bytes.Length);

                allBytes.Add(bytes);
            }

            byte[] combinedBytes = allBytes.SelectMany(x => x).ToArray();

            FileStream write = new FileStream("combined." + files.ElementAt(0).Split(".")[1], FileMode.Create);

            write.Write(combinedBytes, 0, combinedBytes.Length);

            write.Close();
        }
    }
}
