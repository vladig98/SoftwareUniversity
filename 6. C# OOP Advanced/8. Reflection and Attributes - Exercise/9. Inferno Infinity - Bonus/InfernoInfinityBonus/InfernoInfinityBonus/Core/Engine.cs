using InfernoInfinityBonus.Core.Commands;
using InfernoInfinityBonus.Core.IO;
using System;
using System.Linq;
using System.Reflection;

namespace InfernoInfinityBonus.Core
{
    internal class Engine
    {
        IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            string input = InputReader.ReadLineFromConsole();

            while (input != "END")
            {
                try
                {
                    string[] data = input.Split(";");
                    string commandName = data[0];
                    InterpredCommand(commandName, data);
                }
                catch (Exception e)
                {
                    OutputWriter.WriteLine(e.Message);
                }

                input = InputReader.ReadLineFromConsole();
            }
        }

        private void InterpredCommand(string commandName, string[] data)
        {
            string nameSpace = "InfernoInfinityBonus.Core.Commands.";
            Type classType = Type.GetType($"{nameSpace}{commandName}");

            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic;

            FieldInfo[] fields = classType.GetFields(flags).Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(InjectAttribute))).ToArray();
            object[] fieldsArgs = fields.Select(x => serviceProvider.GetService(x.FieldType)).ToArray();

            object instance = Activator.CreateInstance(classType, flags, null, new object[] { data }.Concat(fieldsArgs).ToArray(), null, null);

            MethodInfo method = classType.GetMethods(flags).Where(x => x.Name == "Execute").FirstOrDefault();

            method.Invoke(instance, null);
        }
    }
}
