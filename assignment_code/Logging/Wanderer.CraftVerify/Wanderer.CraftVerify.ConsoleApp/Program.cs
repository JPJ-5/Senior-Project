using Wanderer.CraftVerify.DataAccess;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Server=LÖSTMAYH\\SQLEXPRESS;Database=Steven;User Id=CraftVerifyUser;Password=12345;Trusted_Connection=True";

        DataAccess dataAccess = new DataAccess(connectionString);

        dataAccess.SaveDataToStore("This is a log message.");
    }
}