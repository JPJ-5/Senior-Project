namespace Wanderer.CraftVerify.Logging
{
    using Wanderer.CraftVerify.DataAccess;
    public class Logger
    {
        private DataAccess dataAccess;

        public Logger(string connectionString)
        {
            dataAccess = new DataAccess(connectionString);
        }

        public void CreateLog(string logMessage)
        {
            string logData = $"[{DateTime.Now}] {logMessage}";
            dataAccess.SaveDataToStore(logData);
        }
    }
}