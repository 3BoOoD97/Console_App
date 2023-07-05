using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    public static class Helper
    {
        // Get Connection String from App.Config
        public static string GetConnectionString(string name)
        {
         return ConfigurationManager.ConnectionStrings[name].ToString();
        }
    }
}
