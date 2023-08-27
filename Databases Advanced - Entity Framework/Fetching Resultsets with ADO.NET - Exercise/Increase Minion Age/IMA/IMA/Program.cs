using System;
using System.Data.SqlClient;
using System.Linq;

namespace IMA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string ConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

            int[] minionIDs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string queryToUpdateAgeAndName = "UPDATE Minions\r\nSET Age = Age + 1,\r\n[Name] = LOWER([Name])" +
                "\r\nWHERE Id IN (" + string.Join(", ", minionIDs) + ")";

            string displayMinions = "SELECT *\r\nFROM Minions";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryToUpdateAgeAndName, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(displayMinions, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[1]} {reader[2]}");
                        }

                        reader.Close();
                    }
                }

                connection.Close();
            }
        }
    }
}
