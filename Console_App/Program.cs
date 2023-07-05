using System;
using Console_App.Model;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using Console_App.IRepository;
using Console_App.Repository;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Pseudocode
                 ** PART 1 **
1. Check the number of arguments passed to the application. If the number of arguments
is not equal to 2 or if any argument is null, display an error message and exit the program.
2. Call the addArgs method and pass arguments to it.
3. Display the result obtained from the addArgs method.
4.Implement unit tests for the extensionMethods class by writing unit tests 
to verify the functionality of the addArgs method with different argument types.
                * End of PART 1
                 ----------------
                 ** PART 2 **
1. Create a new SQL database to store the arguments.
2. Create a data layer and repository for storing and retrieving data from the database.
3. Define a table in the database to store the arguments with an appropriate schema.
4. Implement the repository class (`SQLRepository`) that implements the `IArgRepository` interface.
5. In the `SQLRepository` class:
   a. Implement the `AddArg` method to insert the argument into the database table.
   b. Implement the `GetArgs` method to retrieve all arguments from the database table.
6. In the `Program` class:
   a. Create an instance of the repository (`SQLRepository`) and use it to interact with the database.
   b. Call the `AdArg` method of the repository to store the argument in the database.
   c. Call the `getArgs` method of the repository to retrieve all arguments from the database.
   d. Display the retrieved arguments.
7. Implement basic error handling for database connectivity and operations.
8. Implement basic security measures by using parameterized queries to prevent SQL injection attacks.
9. Document the chosen techniques and explain any limitations or considerations made during the implementation.
                * End of PART 2
                 ----------------
              */


            /** PART 1 Implementation **/

            argsErrorhandler(args);

            // Assign the arguments to dynamic variables
            dynamic argument1 = args[0];
            dynamic argument2 = args[1];
            // add the arguments using the extension method and assign the result to a dynamic variable
            dynamic result = argument1.addArgs(argument2);
            // display the result
            Console.WriteLine("The sum of adding the arguments is: " + result);

            //End of PART 1
            Console.WriteLine("---------");
            Console.WriteLine("End of PART 1");
            Console.WriteLine("---------");




            /** PART 2 Implementation **/


            Console.WriteLine("This is the second part of the program, it will add the arguments to the database and display all the data");

            /* Just to make sure that the connection is working
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ArgsDB"].ConnectionString))
              {
                sqlConnection.Open();
                Console.WriteLine("Connection Open ");
              }
            */

            // create a new instance from SQLRepository and call addArg method
            IArgRepository repo = new SQLRepository();
            // repo.AdArg(new Arg() { argValue = (string)result });
            repo.AdArg((string)result);
            var argsList = repo.getArgs();
            displayArgs(argsList);
        }


        private static void argsErrorhandler(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Error! Please enter 2 arguments");
                Environment.Exit(1); // Terminate the program with exit code 1
            }

            // check if there is an arguments equals to null, if so then print an error message and exit the program.
            if (args[0] == null || args[1] == null)
            {
                Console.WriteLine("Error! Arguments can't be null");
                Environment.Exit(1); // Terminate the program with exit code 1
            }
        }
      

        private static void displayArgs(IEnumerable<Arg> args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg.argValue);
            }
        }


        /*
        private static void addArgToDB(string result, IArgRepository IArg)
        {
            IArg.AdArg(new Arg() { argValue = (string)result });
        }
        */
    }

}