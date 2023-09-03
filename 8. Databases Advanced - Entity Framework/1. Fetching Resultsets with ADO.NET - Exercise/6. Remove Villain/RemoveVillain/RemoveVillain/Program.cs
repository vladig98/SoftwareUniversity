using System;
using System.Data.SqlClient;

namespace RemoveVillain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string ConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

            int villianId = int.Parse(Console.ReadLine());
            string villianName = "";

            string queryToDelete = "BEGIN TRANSACTION Tran1\r\nBEGIN TRY\r\n\tDELETE FROM " +
                "MinionsVillains\r\n\tWHERE VillainId = " + villianId + "\r\n\r\n\tDELETE FROM " +
                "Villains\r\n\tWHERE Id = " + villianId + "\r\n\r\n\tCOMMIT TRANSACTION\r\nEND " +
                "TRY\r\nBEGIN CATCH\r\n\tROLLBACK TRANSACTION\r\nEND CATCH";

            string queryToGetName = "SELECT *\r\nFROM Villains\r\nWHERE Id = " + villianId;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryToGetName, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                villianName = reader[1].ToString();
                            }

                            reader.Close();
                        }
                        else
                        {
                            Console.WriteLine("No such villain was found.");
                            reader.Close();
                            connection.Close();
                            return;
                        }
                    }
                }

                using (SqlCommand command = new SqlCommand(queryToDelete, connection))
                {
                    int result = command.ExecuteNonQuery();
                    Console.WriteLine($"{villianName} was deleted.");
                    Console.WriteLine($"{result - 1} minions were released.");
                }

                connection.Close();
            }
        }
    }
}
