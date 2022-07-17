using MySql.Data.MySqlClient;


namespace API.Infra.Data.BancoArtigos
{
    public class BancoArtigos : Conexão
    {
        public static void INSERIR_NOVO_ARTIGO_NO_BANCO_DE_DADOS(string Título, string Conteúdo, string URL)
        {
            try
            {
                using (MySqlCommand Comando = CONEXAO_BANCO().CreateCommand())
                {
                    Comando.CommandText = "INSERT INTO TB_ARTIGO (T_TITULO, T_CONTEUDO, T_URL) VALUES (@Titulo, @Conteudo, @Url)";
                    Comando.Parameters.AddWithValue("@Titulo", Título);
                    Comando.Parameters.AddWithValue("@Conteudo", Conteúdo);
                    Comando.Parameters.AddWithValue("@Url", URL);
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
