using System;
using System.Data;
using System.Data.SqlClient;

namespace IASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string ConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

            int minionID = int.Parse(Console.ReadLine());

            string query = "SELECT * FROM Minions WHERE Id = " + minionID;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("usp_GetOlder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MinionId", SqlDbType.Int).Value = minionID;

                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[1]} - {reader[2]}");
                        }

                        reader.Close();
                    }
                }

                connection.Close();
            }
        }
    }
}
