using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace TNC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string ConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

            string countryName = Console.ReadLine();

            string retrieveTowns = "SELECT *\r\nFROM Countries c\r\nFULL OUTER JOIN Towns t ON t.CountryCode = c.Id\r\nWHERE c.[Name] = '" + countryName + "'";

            List<int> townIds = new List<int>();
            List<string> townNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(retrieveTowns, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string idNull = reader[2].ToString();

                                if (string.IsNullOrEmpty(idNull) || string.IsNullOrWhiteSpace(idNull))
                                {
                                    Console.WriteLine("No town names were affected.");
                                    reader.Close();
                                    connection.Close();
                                    return;
                                }
                                else
                                {
                                    townIds.Add(int.Parse(idNull));
                                    townNames.Add(reader[3].ToString());
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No town names were affected.");
                            reader.Close();
                            return;
                        }
                    }
                }

                string commandToUpdateNames = "UPDATE Towns\r\nSET [Name] = UPPER([Name])\r\nWHERE Id IN (" + string.Join(", ", townIds) + ")";

                using (SqlCommand command = new SqlCommand(commandToUpdateNames, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine($"{townNames.Count} town names were affected");
                    Console.WriteLine($"[{string.Join(", ", townNames.Select(x => x.ToUpper()).ToList())}]");
                }

                connection.Close();
            }
        }
    }
}
