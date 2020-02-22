using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace Loja_de_jogos_God_games_Avaliacao.ConexaoBD
{
    class ConectarBD
    {
        private static string serverName = "localhost";
        private static string port = "5432";
        private static string userName = "postgres";
        private static string password = "gabriel";
        private static string dataBaseName = "ArmazenarJogo";

        public static NpgsqlConnection getConexao()
        {
            try
            {
                string stgConexao = String.Format("Server={0}; Port={1};User Id={2};Password={3};Database={4};",
                       serverName, port, userName, password, dataBaseName);

                NpgsqlConnection npsqlConnection = new NpgsqlConnection(stgConexao);

                npsqlConnection.Open();

                return npsqlConnection;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
