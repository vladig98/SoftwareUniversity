using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSortTest
{
    public class Bubble
    {
        private List<int> Elements;

        public Bubble(List<int> elements)
        {
            Elements = elements;
        }

        public List<int> BubbleSort()
        {
            int length = Elements.Count;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 1; i <= length - 1; i++)
                {
                    if (Elements[i - 1] > Elements[i])
                    {
                        var temp = Elements[i - 1];
                        Elements[i - 1] = Elements[i];
                        Elements[i] = temp;

                        swapped = true;
                    }
                }
            }

            return Elements;
        }
    }
}
