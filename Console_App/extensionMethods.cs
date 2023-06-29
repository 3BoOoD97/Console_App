﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    public class extensionMethods
    {

        public static T addArgs<T>(T arg1, T arg2)
        {
            dynamic dynamicArg1 = arg1;
            dynamic dynamicArg2 = arg2;
            dynamic result = dynamicArg1 + dynamicArg2;
            return result;
        }


        public static object stringConverter(string args)
        {
            int i;
            if (int.TryParse(args, out i))
                return i;
            double d;
            if (double.TryParse(args, out d))
                return d;
            if (float.TryParse(args, out float f))
                return f;
            return args;
        }
    }
}
