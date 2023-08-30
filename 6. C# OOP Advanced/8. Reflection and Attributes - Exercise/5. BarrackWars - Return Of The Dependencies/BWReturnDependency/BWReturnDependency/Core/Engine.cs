using BWReturnDependency.Contracts;
using BWReturnDependency.Core.Commands;
using System;
using System.Linq;
using System.Reflection;

namespace BWReturnDependency.Core
{
    class Engine : IRunnable
    {
        //private IRepository repository;
        //private IUnitFactory unitFactory;
        IServiceProvider serviceProvider;

        public Engine(/*IRepository repository, IUnitFactory unitFactory*/IServiceProvider serviceProvider)
        {
            //this.repository = repository;
            //this.unitFactory = unitFactory;
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {
            string nameSpace = "BWReturnDependency.Core.Commands.";
            Type classType = Type.GetType($"{nameSpace}{commandName[0].ToString().ToUpper()}{string.Join("", commandName.Skip(1).ToArray())}");

            BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic;

            FieldInfo[] fields = classType.GetFields(flags).Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(InjectAttribute))).ToArray();
            object[] fieldsArgs = fields.Select(x => serviceProvider.GetService(x.FieldType)).ToArray();

            object instance = Activator.CreateInstance(classType,flags, null, new object[] { data }.Concat(fieldsArgs).ToArray(), null, null);

            MethodInfo method = classType.GetMethods(flags).Where(x => x.Name == "Execute").FirstOrDefault();

            string result = method.Invoke(instance, null).ToString();

            //switch (commandName)
            //{
            //    case "add":
            //        result = this.AddUnitCommand(data);
            //        break;
            //    case "report":
            //        result = this.ReportCommand(data);
            //        break;
            //    case "fight":
            //        Environment.Exit(0);
            //        break;
            //    case "retire":
            //        RemoveCommand(data);
            //        break;
            //    default:
            //        throw new InvalidOperationException("Invalid command!");
            //}
            return result;
        }

        //private void RemoveCommand(string[] data)
        //{
        //    string unitType = data[1];

        //    repository.RemoveUnit(unitType);
        //}


        //private string ReportCommand(string[] data)
        //{
        //    string output = this.repository.Statistics;
        //    return output;
        //}


        //private string AddUnitCommand(string[] data)
        //{
        //    string unitType = data[1];
        //    IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
        //    this.repository.AddUnit(unitToAdd);
        //    string output = unitType + " added!";
        //    return output;
        //}
    }
}
