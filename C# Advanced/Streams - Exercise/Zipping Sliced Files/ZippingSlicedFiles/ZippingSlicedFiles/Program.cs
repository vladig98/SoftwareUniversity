using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace ZippingSlicedFiles
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

                FileStream compressed = new ("part" + (i + 1) + ext +".gz", FileMode.Create);

                using (GZipStream compressor = new GZipStream(compressed, CompressionMode.Compress))
                {
                    files.Add("part" + (i + 1) + ext + ".gz");

                    if (i == parts - 1)
                    {
                        compressor.Write(readBytes, beginning, readBytes.Length - ((parts - 1) * partLength));
                    }
                    else
                    {
                        compressor.Write(readBytes, beginning, partLength);
                    }
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

                GZipStream decompressor = new GZipStream(read, CompressionMode.Decompress);

                byte[] bytes = new byte[read.Length];

                decompressor.Read(bytes, 0, bytes.Length);

                allBytes.Add(bytes);

                decompressor.Close();

                read.Close();
            }

            byte[] combinedBytes = allBytes.SelectMany(x => x).ToArray();

            FileStream write = new FileStream("combined." + files.ElementAt(0).Split(".")[1], FileMode.Create);

            write.Write(combinedBytes, 0, combinedBytes.Length);

            write.Close();
        }
    }
}
