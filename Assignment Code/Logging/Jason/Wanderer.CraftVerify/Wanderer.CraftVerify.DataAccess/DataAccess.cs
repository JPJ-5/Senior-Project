using Microsoft.Data.SqlClient;

namespace Wanderer.CraftVerify.DataAccess
{
    public static class DataAccess
    {
        public static void RunCommand(SqlCommand command) //run any SQL command to a server specified in the builder
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "localhost";
                builder.UserID = "TestAdmin";
                builder.Password = "TestPassword123";
                builder.InitialCatalog = "TestDatabase";
                builder.TrustServerCertificate = true;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();



                    using (command)
                    {
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
        }

    }
}