using System;
using System.Runtime.CompilerServices;
using Wanderer.CraftVerify.Logging;
class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();
        string message = " testing by sending message";
        logger.CreateLog(message);
        Console.WriteLine("press enter key to exit");
        Console.ReadLine();
    }
}
