using Wanderer.CraftVerify.Logging;

//Example Logging input
int userID = 1; //test ID number
String description = "Hello World"; //test description
String tableName = "testLog"; //the test log table to create a log into.
Logging.CreateLog(userID, description, tableName);

