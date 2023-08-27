using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesLength = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Action<List<string>> sort = names => names.RemoveAll(name => name.Length > namesLength);
            Action<List<string>> print = names => names.ForEach(name => Console.WriteLine(name));

            sort(names);
            print(names);
        }
    }
}
