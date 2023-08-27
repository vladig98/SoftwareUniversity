using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace PAMN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string ConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

            string query = "SELECT *\r\nFROM Minions";

            List<string> minionNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            minionNames.Add(reader[1].ToString());
                        }

                        reader.Close();
                    }
                }

                connection.Close();
            }

            for (int i = 0; i < minionNames.Count; i++)
            {
                int j = minionNames.Count - 1 - i;

                if (i > j)
                {
                    return;
                }

                if (i == j)
                {
                    Console.WriteLine(minionNames.ElementAt(i));

                    return;
                }

                Console.WriteLine(minionNames.ElementAt(i));
                Console.WriteLine(minionNames.ElementAt(j));
            }
        }
    }
}
