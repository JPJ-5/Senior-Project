using DataAccessLib;

namespace Logging
{
    public class Logger
    {
        private readonly DataAccess dataAccess;

        public Logger(string connectionString)
        {
            dataAccess = new DataAccess(connectionString);
        }

        public void Log(string message)
        {
            // Additional logic for formatting or processing the log message can be added here.

            dataAccess.SaveLog(message);
        }
    }
}
