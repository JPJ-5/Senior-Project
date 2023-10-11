using Microsoft.Data.SqlClient;

namespace Wanderer.CraftVerify.Logging
{
    using System.Data;
    using Wanderer.CraftVerify.DataAccess;
    public class Logging
    {
        public static void CreateLog(int userID, String description)
        {
            String timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff"); //format of timestamp is year, month, days, hours, minutes, seconds then miliseconds.
            SqlCommand command = new SqlCommand("INSERT INTO testLog (timestamp, userID, description) VALUES (@timestamp, @userID, @description)");
            command.Parameters.Add("@timestamp", SqlDbType.VarChar).Value = timestamp;
            command.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            DataAccess.RunCommand(command);
        }
    }
}