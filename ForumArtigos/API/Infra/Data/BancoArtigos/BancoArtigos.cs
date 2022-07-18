using MySql.Data.MySqlClient;
using System.Data;

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

        public static DataTable OBTER_TODOS_OS_ARTIGOS_CADASTRADOS()
        {
            try
            {
                using (MySqlCommand Comando = CONEXAO_BANCO().CreateCommand())
                {
                    Comando.CommandText = "SELECT N_ID AS Identificador, T_TITULO AS Titulo, T_CONTEUDO AS Conteudo, T_URL AS URL FROM TB_ARTIGO";
                    using (DataTable Data = new DataTable())
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Comando))
                        {
                            dataAdapter.Fill(Data);
                        }

                        if (Data.Rows.Count > 0)
                        {
                            return Data;
                        }

                        return null;
                    }
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

        public static DataTable BUSCAR_INFORMACOES_DO_ARTIGO(string URLDoArtigo)
        {
            try
            {
                using (MySqlCommand Comando = CONEXAO_BANCO().CreateCommand())
                {
                    Comando.CommandText = "SELECT N_ID AS Identificador, T_TITULO AS Titulo, T_CONTEUDO AS Conteudo, T_URL AS URL FROM TB_ARTIGO WHERE T_URL = @Url";
                    Comando.Parameters.AddWithValue("@Url", URLDoArtigo);

                    using (DataTable Data = new DataTable())
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Comando))
                        {
                            dataAdapter.Fill(Data);
                        }

                        return Data;
                    }
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
