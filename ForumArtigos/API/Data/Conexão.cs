using MySql.Data.MySqlClient;

namespace API.Data
{
    public class Conexão
    {
        private static MySqlConnection conexao;
        protected static MySqlConnection CONEXAO_BANCO()
        {
            try
            {
                conexao = new MySqlConnection("" +
                    "server=127.0.0.1;" +
                    "database=forum_artigos;" +
                    "uid=otavio;" +
                    "pwd=1234;" +
                    "port=3306");
                conexao.Open();
                return conexao;
            }
            catch
            {
                throw new Exception("Não foi possível se conectar com o banco de dados.");
            }
        }
    }
}