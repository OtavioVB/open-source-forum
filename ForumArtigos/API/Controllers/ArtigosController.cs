using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models.Content;
using API.Infra.Data.BancoArtigos;
using API.Infra.CrossCutting;
using System.Data;

namespace API.Controllers
{
    [Route("api/v1/content/artigos")]
    [ApiController]
    public class ArtigosController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            try
            {
                return TratamentoDeJSON.CONVERTER_DATATABLE_PARA_JSON_LIST(BancoArtigos.OBTER_TODOS_OS_ARTIGOS_CADASTRADOS());
            }
            catch
            {
                return "";
            }
        }
        
        
        [HttpPost("criar")]
        public IActionResult Post([FromBody] ArtigosModel Artigo)
        {
            try
            {
                BancoArtigos.INSERIR_NOVO_ARTIGO_NO_BANCO_DE_DADOS(Artigo.Titulo, Artigo.Conteudo, TratamentoDeURL.OBTER_UMA_URL_AMIGÁVEL(Artigo.Titulo));
                return StatusCode(201, "Todas as alterações foram realizadas com sucesso!");
            }
            catch
            {
                return StatusCode(500, "ERRO: Um erro inesperado ocorreu com o servidor e não foi possível fazer o post.");
            }
        }

        [HttpGet("artigo/{url}")]
        public string Get(string url)
        {
            try
            {
                using (DataTable Data = BancoArtigos.BUSCAR_INFORMACOES_DO_ARTIGO(url))
                {
                    return TratamentoDeJSON.CONVERTER_DATATABLE_PARA_JSON_OBJECT(Data);
                }
            }
            catch
            {
                return "";
            }
        }
    }
}
