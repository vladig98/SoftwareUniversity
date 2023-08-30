using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace InfernoInfinity
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
                    Type classType = Type.GetType("InfernoInfinity." + typeArgs[1]);
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
                default:
                    break;
            }
        }
    }
}
