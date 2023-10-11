using Microsoft.Data.SqlClient;

namespace Wanderer.CraftVerify.DataAccess
{
    public class DataAccess
    {
        private String dataSource;
        private String userID;
        private String password;
        private String database;
        public DataAccess(String dataSource, String userID, String password, String database)
        {
            this.dataSource = dataSource;
            this.userID = userID;
            this.password = password;
            this.database = database;
        }

        public void RunCommand(SqlCommand command) //run any SQL command to a server specified in the builder
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = dataSource;
                builder.UserID = userID;
                builder.Password = password;
                builder.InitialCatalog = database;
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