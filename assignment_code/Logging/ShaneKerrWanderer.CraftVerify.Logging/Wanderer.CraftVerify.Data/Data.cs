namespace Wanderer.CraftVerify.Data;
using System.Data.SqlClient;
public class Data
{
    public void SaveData(string data)
    {
        string connectionString = "Server = tcp:wanderer.database.windows.net,1433; Initial Catalog = ShaneKerr.Wanderer.Logging; Persist Security Info = False; User ID = skerr2001; Password =Disney2001; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Create the TestMessages table
            string createTableSql = @"
                CREATE TABLE TestMessages (
                    ID INT IDENTITY(1,1) PRIMARY KEY,
                    Message NVARCHAR(MAX)
                )";

            using (SqlCommand cmd = new SqlCommand(createTableSql, connection))
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("TestMessages table created successfully.");
            }

            // Insert an initial test string
            string initialTestString = data;
            string insertDataSql = "INSERT INTO TestMessages (Message) VALUES (@InitialTestString)";

            using (SqlCommand cmd = new SqlCommand(insertDataSql, connection))
            {
                cmd.Parameters.AddWithValue("@InitialTestString", initialTestString);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Initial test string inserted successfully.");
                }
                else
                {
                    Console.WriteLine("No rows were affected during insertion.");
                }
            }

            connection.Close();
        }
    }
}


