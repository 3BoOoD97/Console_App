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
            // Check if the argument is null or empty
            if (arg == null)
            {
                throw new ArgumentNullException(nameof(arg));
            }
            if (arg == "")
            {
                throw new ArgumentException("Argument cannot be empty", nameof(arg));
            }
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString("ArgsDB")))
            {
                // Insert the argument into the database table using Stored Procedure to prevent SQL injection attacks
                var parameters = new { argValue = arg };
                connection.Execute("InsertArg", parameters, commandType: CommandType.StoredProcedure);

            }
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding an argument: " + ex.Message);
                throw;
            }
        }

      
        public IEnumerable<Arg> getArgs()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString("ArgsDB")))
                {
                    // Retrieve all arguments from the database table. No need for Stored Procedure since it does not include any user input in the SQL query
                    var output = connection.Query<Arg>("SELECT * FROM argTable").ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while getting arguments: "+ex.Message);
                throw;
            }
        }

    }
}
    




