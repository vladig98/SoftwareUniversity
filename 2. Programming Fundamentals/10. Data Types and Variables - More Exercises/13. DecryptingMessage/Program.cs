using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;

            for (int i = 0; i < number; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                decrypted += (char)(letter + key);
            }

            Console.WriteLine(decrypted);
        }
    }
}
