using Wanderer.CraftVerify.Data;

namespace Wanderer.CraftVerify.Logging
{
    using System;
    public class Logger
    {
        private DataAccess dataAccess;

        public Logger()
        {
            dataAccess = new DataAccess();
        }

        public void CreateLog(string logMessage)
        {
            try
            {
                // Your logging logic goes here, such as formatting the log message.
                string formattedLog = $"{DateTime.Now}: {logMessage}";

                // Call the SaveToDataStore method from DataAccess to save the log.
                dataAccess.SaveToDataStore(formattedLog);
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully, log errors, and consider notifying the caller.
                Console.WriteLine($"Error in CreateLog: {ex.Message}");
            }
        }
    }
}