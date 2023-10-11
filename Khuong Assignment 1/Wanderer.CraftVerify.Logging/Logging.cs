using Wanderer.CraftVerify.DataAccess;
namespace Wanderer.CraftVerify.Logging
{
    using System;
    public class Logging
    {
        private DataAccess00 dataAccess;
        public Logging()
        {
            dataAccess = new DataAccess00();
        }
        public void LogMessage(string message)
        {
            // We use this to get message from our console app
            string m = $"{DateTime.Now}: {message}";
            // pass the message to DataAccess Library
            dataAccess.SavingData(m);
        }
        
    }
}