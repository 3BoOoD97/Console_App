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
        public static dynamic AddArgs<T>(this T arg1, T arg2)
        {
            /* Using dynamic variables instead of generic ones so we can Perform 
             * mathematical operations during run time without knowing the type of the variables.*/
            dynamic a = arg1;
            dynamic b = arg2;
            dynamic result = a + b;
            return result;
        }

     
    }
}
