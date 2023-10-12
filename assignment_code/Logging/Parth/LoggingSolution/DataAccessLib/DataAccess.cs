using System.Data.SqlClient;

namespace DataAccessLib
{
    public class DataAccess
    {
        private readonly string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SaveLog(string message)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Logs (Message) VALUES (@Message)", connection))
                {
                    command.Parameters.AddWithValue("@Message", message);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
