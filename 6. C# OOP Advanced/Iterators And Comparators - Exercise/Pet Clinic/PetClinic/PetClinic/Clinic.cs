using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetClinic
{
    public class Clinic
    {
        public string Name { get; set; }
        public int NumberOfRooms { get; set; }
        private Pet[] Rooms { get; set; }

        public Clinic(string name, int numberOfRooms)
        {
            Name = name;
            NumberOfRooms = numberOfRooms;
            Rooms = new Pet[NumberOfRooms];
        }

        public bool HasEmptyRooms()
        {
            return Rooms.Any(x => x == null);
        }

        public bool AddPet(Pet pet)
        {
            int middle = (int)Math.Floor(NumberOfRooms / 2.0);

            int counter = 0;

            for (int i = middle; i < Rooms.Length; i -= counter)
            {
                if (i < 0)
                {
                    continue;
                }

                if (i >= Rooms.Length)
                {
                    continue;
                }

                if (Rooms[i] == null)
                {
                    Rooms[i] = pet;
                    return true;
                }
                else
                {
                    counter = counter <= 0 ? counter - 1 : counter + 1;
                    counter *= -1;
                }
            }

            return false;
        }

        public bool ReleasePet()
        {
            int middle = (int)Math.Floor(NumberOfRooms / 2.0);

            for (int i = middle; i < Rooms.Length; i++)
            {
                if (Rooms[i] != null)
                {
                    Rooms[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < middle; i++)
            {
                if (Rooms[i] != null)
                {
                    Rooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintRoomInfo(int id)
        {
            if (Rooms[id - 1] != null)
            {
                Console.WriteLine(Rooms[id - 1]);
                return;
            }

            Console.WriteLine("Room empty");
        }

        public void PrintAllRooms()
        {
            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i] != null)
                {
                    Console.WriteLine(Rooms[i]);
                }
                else
                {
                    Console.WriteLine("Room empty");
                }
            }
        }
    }
}
