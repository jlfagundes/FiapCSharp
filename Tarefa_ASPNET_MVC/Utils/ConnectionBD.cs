using Tarefa_ASPNET_MVC.Models;
using System.Data;
using System.Data.SqlClient;

namespace Tarefa_ASPNET_MVC.Utils
{
    public class ConnectionBD
    {

        public SqlConnection ConnectBD()
        {
            // STRING DE CONEXAO
            var connectionString = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json")
                                        .Build().GetConnectionString("FiapSmartCityConnection");

            // CONEXAO COM O BANCO DE DADOS
            SqlConnection Connection = new SqlConnection(connectionString);
            return Connection;
        }
    }
}
