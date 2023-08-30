using System;

namespace Database
{
    public class Database
    {
        private int[] Numbers;

        public Database(params int[] numbers)
        {
            Numbers = new int[16];

            if (numbers.Length > 16)
            {
                throw new InvalidOperationException("You need to provide up to 16 integers.");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Numbers[i] = numbers[i];
            }
        }

        public void AddNumber(int number)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == default(int))
                {
                    Numbers[i] = number;
                    return;
                }
            }

            throw new InvalidOperationException("You cannot have more than 16 integers.");
        }

        public void Remove()
        {
            for (int i = Numbers.Length - 1; i >= 0; i--)
            {
                if (Numbers[i] != default(int))
                {
                    Numbers[i] = default(int);
                    return;
                }
            }

            throw new InvalidOperationException("There are no elements to remove.");
        }

        public int[] Fetch()
        {
            return Numbers;
        }
    }
}
