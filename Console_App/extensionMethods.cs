using Console_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    public static class ExtensionMethods
    {
        // addArgs method to add two arguments 
        public static dynamic addArgs(this dynamic arg1, dynamic arg2)
        {
           /* Using dynamic variables instead of generic ones so we can Perform 
            * mathematical operations during run time without knowing the type of the variables.*/
            dynamic result = arg1 + arg2;
            return result;
        }

     
    }
}
