using System.Web;

namespace API.Infra.CrossCutting
{
    public static class TratamentoDeURL
    {
        public static string OBTER_UMA_URL_AMIGÁVEL(string Texto)
        {
            string NovoTexto = Texto.Replace('"', ' ');
            NovoTexto = NovoTexto.Replace(',', ' ');
            NovoTexto = NovoTexto.ToLower();
            NovoTexto = NovoTexto.Replace("ç", "c");
            NovoTexto = NovoTexto.Replace("!", "");
            NovoTexto = NovoTexto.Replace(" ", "-");
            NovoTexto = NovoTexto.Replace("#", "");
            NovoTexto = NovoTexto.Replace("$", "");
            NovoTexto = NovoTexto.Replace("%", "");
            NovoTexto = NovoTexto.Replace("&", "");
            NovoTexto = NovoTexto.Replace("'", "");
            NovoTexto = NovoTexto.Replace("(", "");
            NovoTexto = NovoTexto.Replace(")", "");
            NovoTexto = NovoTexto.Replace("*", "");
            NovoTexto = NovoTexto.Replace("+", "");
            NovoTexto = NovoTexto.Replace("`", "");
            NovoTexto = NovoTexto.Replace(".", "");
            NovoTexto = NovoTexto.Replace("/", "");
            NovoTexto = NovoTexto.Replace(":", "");
            NovoTexto = NovoTexto.Replace(";", "");
            NovoTexto = NovoTexto.Replace("<", "");
            NovoTexto = NovoTexto.Replace(">", "");
            NovoTexto = NovoTexto.Replace("=", "");
            NovoTexto = NovoTexto.Replace("?", "");
            NovoTexto = NovoTexto.Replace("@", "");
            NovoTexto = NovoTexto.Replace("[", "");
            NovoTexto = NovoTexto.Replace("]", "");
            NovoTexto = NovoTexto.Replace(@"\", "");
            NovoTexto = NovoTexto.Replace("^", "");
            NovoTexto = NovoTexto.Replace("_", "");
            NovoTexto = NovoTexto.Replace("´", "");
            NovoTexto = NovoTexto.Replace("{", "");
            NovoTexto = NovoTexto.Replace("|", "");
            NovoTexto = NovoTexto.Replace("}", "");
            NovoTexto = NovoTexto.Replace("~", "");
            NovoTexto = NovoTexto.Replace("Ā", "a");
            NovoTexto = NovoTexto.Replace("ā", "a");
            NovoTexto = NovoTexto.Replace("Ē", "e");
            NovoTexto = NovoTexto.Replace("ē", "e");
            NovoTexto = NovoTexto.Replace("Ī", "i");
            NovoTexto = NovoTexto.Replace("ī", "i");
            NovoTexto = NovoTexto.Replace("Ō", "o");
            NovoTexto = NovoTexto.Replace("ō", "o");
            NovoTexto = NovoTexto.Replace("Ū", "u");
            NovoTexto = NovoTexto.Replace("ū", "u");
            NovoTexto = NovoTexto.Replace("á", "a");
            NovoTexto = NovoTexto.Replace("ã", "a");
            NovoTexto = NovoTexto.Replace("à", "a");
            NovoTexto = NovoTexto.Replace("â", "a");
            NovoTexto = NovoTexto.Replace("é", "e");
            NovoTexto = NovoTexto.Replace("è", "e");
            NovoTexto = NovoTexto.Replace("ê", "e");
            NovoTexto = NovoTexto.Replace("í", "i");
            NovoTexto = NovoTexto.Replace("ì", "i");
            NovoTexto = NovoTexto.Replace("î", "i");
            NovoTexto = NovoTexto.Replace("ô", "o");
            NovoTexto = NovoTexto.Replace("ò", "o");
            NovoTexto = NovoTexto.Replace("õ", "o");
            NovoTexto = NovoTexto.Replace("ó", "o");
            NovoTexto = NovoTexto.Replace("û", "u");
            NovoTexto = NovoTexto.Replace("ú", "u");
            NovoTexto = NovoTexto.Replace("ù", "u");
            NovoTexto = NovoTexto.Replace("ý", "y");
            NovoTexto = NovoTexto.Replace("§", "");
            NovoTexto = NovoTexto.Replace("£", "");
            NovoTexto = NovoTexto.Replace("@", "");
            NovoTexto = NovoTexto.Replace("¢", "");
            NovoTexto = NovoTexto.Replace("ª", "");
            NovoTexto = NovoTexto.Replace("º", "");
            return NovoTexto;
        }
    }
}
