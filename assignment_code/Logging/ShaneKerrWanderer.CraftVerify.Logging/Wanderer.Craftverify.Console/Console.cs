using System;
using System.Data.SqlClient;
using Wanderer.CraftVerify.Logging;
public class Console
{
    public static void Main()
    {
        Logger logger = new Logger();
        logger.CreateLog("This is a test string");
    }
}