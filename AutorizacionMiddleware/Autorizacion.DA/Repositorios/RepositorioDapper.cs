using Autorizacion.Abstracciones.DA;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Autorizacion.DA.Repositorios
{
    public class RepositorioDapper : IRepositorioDapper
    {
        private readonly IConfiguration _configuration;
        private SqlConnection _connection;

        public RepositorioDapper(IConfiguration configuration, SqlConnection connection)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("BDSeguridad"));
        }

        public SqlConnection ObtenerRepositorioDapper()
        {
            return _connection;
        }
    }
}
