using MySql.Data.MySqlClient;
using System.Data;

namespace WebApp.Models
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new MySqlConnection(_connectionString);

        public IDbConnection CreateDynamicConnection(string _dynamicconnectionString) => new MySqlConnection(_dynamicconnectionString);
    }
}
