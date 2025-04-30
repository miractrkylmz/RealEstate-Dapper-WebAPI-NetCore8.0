using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace RealEstate_Dapper_API.Models.DapperContext
{
    public class Context(IConfiguration _configuration)
    {
        private readonly string _connectionString = _configuration.GetConnectionString("connection");
        
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
