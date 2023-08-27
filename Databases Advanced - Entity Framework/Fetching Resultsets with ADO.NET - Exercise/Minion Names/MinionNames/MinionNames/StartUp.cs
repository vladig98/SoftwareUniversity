using System;
using System.Data.SqlClient;

namespace MinionNames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string ConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

            string villianId = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string queryToExecute = "SELECT m.[Name], m.Age, v.[Name]\r\nFROM Minions m\r\nINNER JOIN MinionsVillains mv ON " +
                    "mv.MinionId= m.Id\r\nINNER JOIN Villains v ON v.Id = mv.VillainId\r\nWHERE v.Id = " + villianId + "\r\nORDER BY m.[Name]";

                using (SqlCommand command = new SqlCommand(queryToExecute, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            string checkIfVillianExists = "SELECT Id, [Name]\r\nFROM Villains WHERE Id = " + villianId;

                            reader.Close();

                            using (SqlCommand villianCommand = new SqlCommand(checkIfVillianExists, connection))
                            {
                                using (SqlDataReader reader2 = villianCommand.ExecuteReader())
                                {
                                    if (!reader2.HasRows)
                                    {
                                        Console.WriteLine($"No villain with ID {villianId} exists in the database.");
                                    }
                                    else
                                    {
                                        while (reader2.Read())
                                        {
                                            Console.WriteLine($"Villain: {reader2[1]}");
                                            Console.WriteLine("(no minions)");
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool isVillianPrinted = false;
                            int counter = 1;

                            while (reader.Read())
                            {
                                if (!isVillianPrinted)
                                {
                                    Console.WriteLine($"Villain: {reader[2]}");
                                    isVillianPrinted = true;
                                }

                                Console.WriteLine($"{counter++}. {reader[0]} {reader[1]}");
                            }
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
