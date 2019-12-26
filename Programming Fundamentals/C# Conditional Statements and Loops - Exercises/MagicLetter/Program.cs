using System;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());

            for (int i = letter1; i <= letter2; i++)
            {
                for (int j = letter1; j <= letter2; j++)
                {
                    for (int k = letter1; k <= letter2; k++)
                    {
                        string word = ((char)i).ToString() + ((char)j).ToString() + ((char)k).ToString();
                        if (!word.Contains(((char)letter).ToString()))
                        {
                            Console.Write(word + " ");
                        }
                    }
                }
            }
        }
    }
}
