using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        public List<int> Path { get; set; }

        public Lake()
        {
            Path = new List<int>();
        }

        private IEnumerable<int> List()
        {
            foreach (var item in Path)
            {
                yield return item;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return List().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Jump(List<int> leaves)
        {
            for (int i = 0; i < leaves.Count; i += 2)
            {
                Path.Add(leaves[i]);
            }

            for (int i = leaves.Count - 1; i >= 0; i -= 2)
            {
                if (i % 2 == 0)
                {
                    i++;
                }
                else
                {
                    Path.Add(leaves[i]);
                }
            }
        }
    }
}
