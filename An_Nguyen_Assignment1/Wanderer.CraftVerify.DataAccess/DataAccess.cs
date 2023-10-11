namespace Wanderer.CraftVerify.DataAccess
{
    using System;
    using System.Data.SqlClient;
    

    public class DataAccess01
    {
        public void SaveToDataStore(string data)
        {
            //using connetion string to gain server access 
            string connectionString = "Server=DESKTOP-G4VUJ7S\\SQLEXPRESS;Database=CraftVerify;User Id=AnNguyen;Password=123456";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //establish the connection to database
                connection.Open();
                Console.WriteLine("trying to to connect to SQL sv 491A Assigngment 1");

                // create a test message
                string testMessage = "This is a test message again.";
                //insert message to table
                string insertSql = "INSERT INTO test (message) VALUES (@testMessage)";

                    
                //execute sql insert statement
                using (SqlCommand cmd = new SqlCommand(insertSql, connection))
                {
                    cmd.Parameters.AddWithValue("@testMessage", testMessage);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted ");
                    }
                    else
                    {
                        Console.WriteLine("Fail to insert data");
                    }
                }

                connection.Close();
            }
        }
    }
}