using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CustomClassAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IWeapon> weapons = new List<IWeapon>();

            while (input != "END")
            {
                string[] tokens = input.Split(';');

                string command = tokens[0];

                CommandInterpreter(command, tokens, weapons);

                input = Console.ReadLine();
            }
        }

        private static void CommandInterpreter(string command, string[] tokens, List<IWeapon> weapons)
        {
            switch (command)
            {
                case "Create":
                    string[] typeArgs = tokens[1].Split(' ');
                    Type classType = Type.GetType("CustomClassAttribute." + typeArgs[1]);
                    BindingFlags flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic;
                    object instance = Activator.CreateInstance(classType, flags, null, new object[] { tokens[2], typeArgs[0] }, null, null);
                    weapons.Add((IWeapon)instance);
                    break;
                case "Add":
                    IWeapon weapon = weapons.Where(x => x.Name == tokens[1]).FirstOrDefault();
                    weapon.AddGem(int.Parse(tokens[2]), tokens[3]);
                    break;
                case "Remove":
                    IWeapon weapon1 = weapons.Where(x => x.Name == tokens[1]).FirstOrDefault();
                    weapon1.RemoveGem(int.Parse(tokens[2]));
                    break;
                case "Print":
                    IWeapon weaponToPrint = weapons.Where(x => x.Name == tokens[1]).FirstOrDefault();
                    weaponToPrint.UpdateStats();
                    Console.WriteLine(weaponToPrint);
                    break;
                case "Author":
                    Type classType2 = Type.GetType("CustomClassAttribute.Sword");
                    var attribute1 = classType2.GetCustomAttributes().Where(x => x.GetType() == typeof(CustomClassAttribute)).First();
                    Console.WriteLine("Author: " + ((CustomClassAttribute)attribute1).Author);
                    break;
                case "Revision":
                    Type classType3 = Type.GetType("CustomClassAttribute.Sword");
                    var attribute2 = classType3.GetCustomAttributes().Where(x => x.GetType() == typeof(CustomClassAttribute)).First();
                    Console.WriteLine("Revision: " + ((CustomClassAttribute)attribute2).Revision);
                    break;
                case "Description":
                    Type classType4 = Type.GetType("CustomClassAttribute.Sword");
                    var attribute3 = classType4.GetCustomAttributes().Where(x => x.GetType() == typeof(CustomClassAttribute)).First();
                    Console.WriteLine("Class description: " + ((CustomClassAttribute)attribute3).Description);
                    break;
                case "Reviewers":
                    Type classType5 = Type.GetType("CustomClassAttribute.Sword");
                    var attribute4 = classType5.GetCustomAttributes().Where(x => x.GetType() == typeof(CustomClassAttribute)).First();
                    Console.WriteLine("Reviewers: " + String.Join(", ", ((CustomClassAttribute)attribute4).Reviewers));
                    break;
                default:
                    break;
            }
        }
    }
}
