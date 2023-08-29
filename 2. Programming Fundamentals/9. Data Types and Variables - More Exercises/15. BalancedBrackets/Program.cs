using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());

            bool openingBracket = false;
            bool unbalanced = false;

            for (int i = 0; i < numberOfInputLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (openingBracket)
                    {
                        unbalanced = true;
                    }
                    openingBracket = true;
                }
                else if (input == ")")
                {
                    if (!openingBracket)
                    {
                        unbalanced = true;
                    }
                    else
                    {
                        openingBracket = false;
                    }
                }
            }

            if (unbalanced || openingBracket)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
