using Wanderer.CraftVerify.Logging;
class OurProgram
{
    static void Main(string[] args)
    {
        // Create a new Logging object
        Logging logging = new Logging();
        // String for testing
        string test = "Khuong is here yay 3";
        // We log the test message
        logging.LogMessage(test);
        Console.ReadLine();


    }
}

