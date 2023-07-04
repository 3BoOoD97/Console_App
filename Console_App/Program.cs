using System;
using Console_App.Model;
using Console_App.DataContext;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Pseudocode
                ** PART 1 **
                * Send arguments to the Main method while executing the code.
                * Catch and handle errors if any.
                  Check if the number of arguments is not equal to 2 or if it equals to null then print an error message and exit the program.
                * Call stringConverter method to convert arguments to their real type and assign the values to var variables.
                * Call add method and pass the var variables to it.
                * Display the result
                * End of PART 1
                 ----------------
              */

            Console.WriteLine("Connection Open1 ");

            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ArgsDB"].ConnectionString))
            {
                sqlConnection.Open();
                Console.WriteLine("Connection Open ");
            }
            // check if the number of arguments, if it is not equal to 2 then print an error message and exit the program.
            if (args.Length != 2)
            {
                Console.WriteLine("Error! Please enter 2 arguments");
                return;
            }

            // check if there is an arguments equals to null, if so then print an error message and exit the program.
            if (args[0] == null || args[1] == null)
            {
                Console.WriteLine("Error! Please enter 2 arguments");
                return;
            }

            // create a new instance from ExtensionMethods and call add method
            var argument1 = extensionMethods.stringConverter(args[0]);
            var argument2 = extensionMethods.stringConverter(args[1]);

            // display the result
            var result = extensionMethods.addArgs(argument1, argument2);
            Console.WriteLine(result);


            Console.WriteLine("---------");

            insertArg(result.ToString());
            argsTable();

        }



        /* Pseudocode
                ** PART 2 **
                * Create a new instance from DBContext class.
                * Create a new instance from argClass class.
                * Assign the values to the properties of argClass.
                * Add the instance of argClass to the DBContext.
                * Save the changes.
                * Display the result.
                * End of PART 2
                 ----------------
              */
        static void argsTable()
        {
            Console.WriteLine(
                "This is the second part of the program, it will add the arguments to the database and display the result");
            // create a new instance from DBContext class

            using (var result = new DBContext())
            {
                List<argClass> args = result.argTable.ToList();

                StringBuilder sb = new StringBuilder();

                foreach (var arg in args)
                {
                  //  Console.WriteLine(arg.argValue);
                    sb.AppendLine(arg.argValue);
                }

                Console.WriteLine(sb.ToString());
            }
            return;
        }

        static void insertArg(string arg)
        {
            using (var result = new DBContext())
            {
                var argClass = new argClass();
                argClass.argValue = arg;
                result.argTable.Add(argClass);
                result.SaveChanges();
            }
            return;

        }
    }
    }