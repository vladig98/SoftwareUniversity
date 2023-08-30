using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<Pet> pets = new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");

                switch (tokens[0])
                {
                    case "Create":
                        switch (tokens[1])
                        {
                            case "Pet":
                                pets.Add(new Pet(tokens[2], int.Parse(tokens[3]), tokens[4]));
                                break;
                            case "Clinic":
                                if (int.Parse(tokens[3]) % 2 == 0)
                                {
                                    Console.WriteLine("Invalid Operation!");
                                    break;
                                }
                                clinics.Add(new Clinic(tokens[2], int.Parse(tokens[3])));
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Add":
                        Console.WriteLine(clinics.Where(x => x.Name == tokens[2]).First().AddPet(pets.Where(x => x.Name == tokens[1]).First()));
                        break;
                    case "Release":
                        Console.WriteLine(clinics.Where(x => x.Name == tokens[1]).First().ReleasePet());
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(clinics.Where(x => x.Name == tokens[1]).First().HasEmptyRooms());
                        break;
                    case "Print":
                        if (tokens.Length > 2)
                        {
                            clinics.Where(x => x.Name == tokens[1]).First().PrintRoomInfo(int.Parse(tokens[2]));
                            break;
                        }
                        clinics.Where(x => x.Name == tokens[1]).First().PrintAllRooms();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
