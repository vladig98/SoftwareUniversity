using BusTicketsSystem.Client.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace BusTicketsSystem.Client.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Read(string[] input)
        {
            string inputCommand = GetName(input[0]) + "Command";

            string[] args = input.Skip(1).ToArray();

            var type = Assembly.GetCallingAssembly()
                               .GetTypes()
                               .FirstOrDefault(x => x.Name == inputCommand);

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            var constructor = type.GetConstructors()
                                  .First();

            var constructorParameters = constructor.GetParameters()
                                                   .Select(x => x.ParameterType)
                                                   .ToArray();

            var service = constructorParameters.Select(serviceProvider.GetService)
                                               .ToArray();

            var command = (ICommand)constructor.Invoke(service);

            string result = command.Execute(args);

            return result;
        }

        private string GetName(string name)
        {
            string result = string.Empty;

            var tokens = name.Split("-");

            for (int i = 0; i < tokens.Length; i++)
            {
                result += tokens[i][0].ToString().ToUpper() + string.Join("", tokens[i].Skip(1).ToArray());
            }

            return result;
        }
    }
}
