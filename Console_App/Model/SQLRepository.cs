using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using NLog.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using Console_App.IRepository;

namespace Console_App.Model
{
    class SQLRepository : IArgRepository
    {
        public void AdArg(argClass arg)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<argClass> gerArgs()
        {
            List<argClass> args = new List<argClass>();
            using (SqlConnection connection =
            new SqlConnection(ConfigurationManager.ConnectionStrings["ArgsDB"].ToString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM argTable", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                argClass arg = new argClass()
                                {
                                    argValue = reader["argValue"].ToString()),

                                };
                                args.Add(arg);
                            }
                        }
                    }
                }

                return args;
            }

        }
    }
}

