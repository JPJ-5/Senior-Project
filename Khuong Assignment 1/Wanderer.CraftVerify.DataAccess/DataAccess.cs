namespace Wanderer.CraftVerify.DataAccess
{
    using System;
    using System.Data.SqlClient;
    public class DataAccess00
    {
        public void SavingData(string data)
        {
            // The connection string for my database
            string connectionString = "Server=KHUONGLAPTOP\\SQLEXPRESS;Database=CraftVerifyTest;User Id=CraftVerifyTestKhuong;Password=heomep0307;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // For a connecction with the data base
                connection.Open();
                Console.WriteLine("CECS 491A Assignment: Connected Sucessfully");

                // Insert the string from console 
                string StringTrial = data;
                // SQL Command for INSERT
                string SQLinserting = "INSERT INTO TestCraft (StringTrial) VALUES (@StringTrial)";


                using (SqlCommand cmd = new SqlCommand(SQLinserting, connection))
                {
                    cmd.Parameters.AddWithValue("@StringTrial", StringTrial);
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}