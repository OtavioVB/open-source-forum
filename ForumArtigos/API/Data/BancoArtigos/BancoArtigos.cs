using MySql.Data.MySqlClient;

namespace API.Data.BancoArtigos
{
    public class BancoArtigos : Conexão
    {
        public static void INSERIR_NOVO_ARTIGO_NO_BANCO_DE_DADOS(string Título, string Conteúdo)
        {
            try
            {
                using (MySqlCommand Comando = CONEXAO_BANCO().CreateCommand())
                {
                    Comando.CommandText = "INSERT INTO TB_ARTIGOS";
                    Comando.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                CONEXAO_BANCO().Close();
            }
        }
    }
}
