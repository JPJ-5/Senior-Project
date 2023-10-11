using Wanderer.CraftVerify.Logging;

//Example Logging input
String dataSource = "localhost";
String userAdmin = "TestAdmin";
String password = "TestPassword123";
String database = "TestDatabase";
//create logging class
Logging testLogging = new Logging(dataSource, userAdmin, password, database);

int userID = 1; //test ID number
String description = "Hello World!"; //test description
String tableName = "testLog"; //the test log table to create a log into.
testLogging.CreateLog(userID, description, tableName);

