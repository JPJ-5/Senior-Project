using System;
using Wanderer.CraftVerify.Logging;
class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();

        // Use the DataAccess and Logger classes as needed

        string logMessage = "This is a test message";
        logger.CreateLog(logMessage);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}

