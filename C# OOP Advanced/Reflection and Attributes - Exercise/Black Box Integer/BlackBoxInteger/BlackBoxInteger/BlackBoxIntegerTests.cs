using System;
using System.Reflection;

namespace BlackBoxInteger
{
    internal class BlackBoxIntegerTests
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Type className = Type.GetType("BlackBoxInteger.BlackBoxInteger");
            object instance = Activator.CreateInstance(className, true);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

            while (input != "END")
            {
                string[] tokens = input.Split('_');

                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                className.GetMethod(methodName, flags).Invoke(instance, new object[] { value });
                var obj = className.GetField("innerValue", flags);
                Console.WriteLine(obj.GetValue(instance));

                input = Console.ReadLine();
            }
        }
    }
}
