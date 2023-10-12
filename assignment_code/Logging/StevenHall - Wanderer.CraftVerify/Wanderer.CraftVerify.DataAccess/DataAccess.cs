namespace Wanderer.CraftVerify.DataAccess
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class DataAccess
    {
        private string connectionString = "Server=LÖSTMAYH\\SQLEXPRESS;Database=Steven;User Id=CraftVerifyUser;Password=12345;Trusted_Connection=True";

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Method to create the 'LogData' table
        public void CreateLogDataTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string createTableSql = @"
                    CREATE TABLE LogData (
                        LogID INT PRIMARY KEY IDENTITY(1,1),
                        LogMessage NVARCHAR(MAX),
                        LogTimestamp DATETIME
                    )";

                using (SqlCommand command = new SqlCommand(createTableSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SaveDataToStore(string data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO LogData (LogMessage, LogTimestamp) VALUES (@LogMessage, @LogTimestamp)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@LogMessage", data);
                    command.Parameters.AddWithValue("@LogTimestamp", DateTime.Now);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}