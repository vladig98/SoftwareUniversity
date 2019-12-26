using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 1;
            const int e = 2;
            const int i = 3;
            const int o = 4;
            const int u = 5;

            string word = Console.ReadLine();
            int sum = 0;

            for (int j = 0; j < word.Length; j++)
            {
                switch (word[j])
                {
                    case 'a':
                        sum += a;
                        break;
                    case 'e':
                        sum += e;
                        break;
                    case 'i':
                        sum += i;
                        break;
                    case 'o':
                        sum += o;
                        break;
                    case 'u':
                        sum += u;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
