using System;
using Logging;

namespace LoggingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=LoggingDb;Trusted_Connection=True;";
            var logger = new Logger(connectionString);
            logger.Log("Hi! checking");

            Console.WriteLine("Log has been created!");
   
        }
    }
}
