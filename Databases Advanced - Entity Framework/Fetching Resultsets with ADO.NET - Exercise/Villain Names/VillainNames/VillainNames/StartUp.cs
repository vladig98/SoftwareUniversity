using System;
using System.Data.SqlClient;

namespace VillainNames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
            {
                connection.Open();

                string queryToExecute = "SELECT * FROM (\r\nSELECT v.[Name], COUNT(m.Id) [Number of Minions]" +
                    "\r\nFROM Minions m\r\nINNER JOIN MinionsVillains mv ON mv.MinionId = m.Id\r\n" +
                    "INNER JOIN Villains v ON v.Id = mv.VillainId\r\nGROUP BY v.[Name]) sub\r\nWHERE " +
                    "sub.[Number of Minions] > 3\r\nORDER BY [Number of Minions] DESC";

                using (SqlCommand command = new SqlCommand(queryToExecute, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} - {reader[1]}");
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
