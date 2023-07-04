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
using Console_App.Model;

namespace Console_App.Repository
{
    class SQLRepository : IArgRepository
    {
        public void AdArg(Arg arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException(nameof(arg));
            }

            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["ArgsDB"].ToString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO argTable (argValue) VALUES (@argValue)", connection))
                {
                    cmd.Parameters.AddWithValue("@argValue", arg.argValue);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }

        }


        public IEnumerable<Arg> getArgs()
        {
            List<Arg> args = new List<Arg>();
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
                                Arg arg = new Arg()
                                {
                                    argValue = reader["argValue"].ToString(),

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

