using System;
using System.Data.SqlClient;

namespace AddMinion
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string ConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

            string minionInfo = Console.ReadLine();
            string villianInfo = Console.ReadLine();

            string[] minionDetails = minionInfo.Split(":")[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string minionName = minionDetails[0];
            int age = int.Parse(minionDetails[1]);
            string townName = minionDetails[2];

            string villianName = villianInfo.Split(":")[1].Trim();

            string queryToCheckIfTownExists = "SELECT *\r\nFROM Towns\r\nWHERE [Name] = \'" + townName + "\'";
            string queryToInserTown = "INSERT INTO Towns\r\nVALUES ('" + townName + "', NULL)";
            int townID = 0;

            string queryToCheckIfVillianExists = "SELECT *\r\nFROM Villains\r\nWHERE [Name] = \'" + villianName + "\'";
            string queryToInsertVillians = "INSERT INTO Villains\r\nVALUES ('" + villianName + "', 4)";
            int villianID = 0;

            int minionId = 0;

            string queryToGetMinionID = "SELECT MAX(Id) FROM Minions";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryToCheckIfTownExists, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                townID = int.Parse(reader[0].ToString());
                            }
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();

                            using (SqlCommand command2 = new SqlCommand(queryToInserTown, connection))
                            {
                                command2.ExecuteNonQuery();
                                Console.WriteLine($"Town {townName} was added to the database.");
                            }

                            using (SqlDataReader reader2 = command.ExecuteReader())
                            {
                                while (reader2.Read())
                                {
                                    townID = int.Parse(reader2[0].ToString());
                                }
                                reader2.Close();
                            }
                        }
                    }
                }

                using (SqlCommand command = new SqlCommand(queryToCheckIfVillianExists, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                villianID = int.Parse(reader[0].ToString());
                            }
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();

                            using (SqlCommand command2 = new SqlCommand(queryToInsertVillians, connection))
                            {
                                command2.ExecuteNonQuery();
                                Console.WriteLine($"Villain {villianName} was added to the database.");
                            }

                            using (SqlDataReader reader2 = command.ExecuteReader())
                            {
                                while (reader2.Read())
                                {
                                    villianID = int.Parse(reader2[0].ToString());
                                }
                                reader2.Close();
                            }
                        }
                    }
                }

                string queryToInsertMinion = "INSERT INTO Minions\r\nVALUES ('" + minionName + "', " + age + ", " + townID + ")";

                using (SqlCommand command = new SqlCommand(queryToInsertMinion, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(queryToGetMinionID, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            minionId = int.Parse(reader[0].ToString());
                        }
                        reader.Close();
                    }
                }

                string queryToAssignMinionToVillian = "INSERT INTO MinionsVillains\r\nVALUES (" + minionId + ", " + villianID + ")";

                using (SqlCommand command = new SqlCommand(queryToAssignMinionToVillian, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine($"Successfully added {minionName} to be minion of {villianName}.");
                }

                connection.Close();
            }
        }
    }
}
