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
using Dapper;
using System.Data;

namespace Console_App.Repository
{
    class SQLRepository : IArgRepository
    {

/*
 * Dapper library is used to access the database, since it is Light in size, easy to handle, 
 and high in performance. 
* Stored Procedure is used, so the code can be reused and it is a good defense against
 SQL injection attacks because the incoming parameters are never parsed.
        */
        public void AdArg(string arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException(nameof(arg));
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString("ArgsDB")))
            {
                var parameters = new { argValue = arg };
                connection.Execute("InsertArg", parameters, commandType: CommandType.StoredProcedure);

            }
        }

      
        public IEnumerable<Arg> getArgs()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString("ArgsDB")))
            {
                var output = connection.Query<Arg>("SELECT * FROM argTable").ToList();
                return output;
            }
        }

    }
}
    




