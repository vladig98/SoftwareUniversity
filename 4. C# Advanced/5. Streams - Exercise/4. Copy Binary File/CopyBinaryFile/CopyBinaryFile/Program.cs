using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("copyMe.png", FileMode.Open);

            byte[] readBytes = new byte[fileStream.Length];

            fileStream.Read(readBytes, 0, readBytes.Length);

            fileStream.Close();

            fileStream = new FileStream("copied.png", FileMode.Create, FileAccess.ReadWrite, FileShare.None, 8, FileOptions.None);

            fileStream.Write(readBytes, 0, readBytes.Length);

            fileStream.Close();
        }
    }
}
