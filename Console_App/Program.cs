using System;

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
                  1- Check if the number of arguments is not equal to 2 then print an error message and exit the program.
                * Create a new instance from ExtensionMethods and call add method call stringConverter method to convert 
                  the arguments to the same type.
                * Call add method and pass the arguments to it.
                * Display the result
                * End of PART 1
                 ----------------
              */




            // check if the number of arguments is not equal to 2 then print an error message and exit the program.
            if (args.Length != 2)
            {
                Console.WriteLine("Error! Please enter 2 arguments");
                return;
            }

            if (args[0] == null || args[1] == null)
            {
                Console.WriteLine("Error! Please enter 2 arguments");
                return;
            }

            // create an instance from extensionMethods class
            extensionMethods obj = new extensionMethods();

            // create a new instance from ExtensionMethods and call add method
            var argument1 = extensionMethods.stringConverter(args[0]);
            var argument2 = extensionMethods.stringConverter(args[1]);

           
            // display the result
            var result = extensionMethods.addArgs(argument1, argument2);
            Console.WriteLine(result);

        }
    }