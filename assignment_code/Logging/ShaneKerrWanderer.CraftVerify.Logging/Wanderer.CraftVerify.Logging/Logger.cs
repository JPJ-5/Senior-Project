namespace Wanderer.CraftVerify.Logging;
using Microsoft.SqlServer.Server;
using System;
using Wanderer.CraftVerify.Data;

public class Logger
    {
        private Data dataAccess;

        public Logger()
        {
             dataAccess = new Data();
        }
        public void CreateLog(string logMessage)
            {
            try
            {
                string formattedLog = $"{DateTime.Now}: {logMessage}";
                dataAccess.SaveData(formattedLog);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateLog: {ex.Message}");
            }
            }
  }