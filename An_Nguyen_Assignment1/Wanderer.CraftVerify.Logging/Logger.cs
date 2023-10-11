using Wanderer.CraftVerify.DataAccess;

namespace Wanderer.CraftVerify.Logging
{
    using System;
    public class Logger
    {
        private DataAccess01 dataAccess;

        public Logger()
        {
            dataAccess = new DataAccess01();
        }

        public void CreateLog(string logMessage)
        {
            String formattedLog = $"{DateTime.Now}: {logMessage}";
            dataAccess.SaveToDataStore(formattedLog);
        }


    }
}