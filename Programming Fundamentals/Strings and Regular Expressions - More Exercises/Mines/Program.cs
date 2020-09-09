using System;
using System.Text.RegularExpressions;

namespace Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string mineField = Console.ReadLine();

            MatchCollection mines = Regex.Matches(mineField, @"<.{2,2}>");

            foreach (Match mine in mines)
            {
                int mineExplosionRadius = Math.Abs(mine.Value[1] - mine.Value[2]);
                int beginningOfMine = mineField.IndexOf(mine.Value);
                for (int i = beginningOfMine - 1; i >= beginningOfMine - mineExplosionRadius; i--)
                {
                    if (i < 0)
                    {
                        break;
                    }
                    if (mineField[i] != '>' && mineField[i] != '<')
                    {
                        mineField = mineField.Remove(i, 1);
                        mineField = mineField.Insert(i, "_");
                    }
                }

                int endingOfMine = beginningOfMine + 3;

                for (int i = endingOfMine + 1; i < endingOfMine + mineExplosionRadius + 1; i++)
                {
                    if (i >= mineField.Length)
                    {
                        break;
                    }
                    if (mineField[i] != '>' && mineField[i] != '<')
                    {
                        mineField = mineField.Remove(i, 1);
                        mineField = mineField.Insert(i, "_");
                    }
                }

                mineField = mineField.Remove(beginningOfMine, 4);
                mineField = mineField.Insert(beginningOfMine, "____");
            }

            Console.WriteLine(mineField);
        }
    }
}
