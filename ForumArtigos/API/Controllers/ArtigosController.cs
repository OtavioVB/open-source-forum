﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models.Content;
using API.Infra.Data.BancoArtigos;
using API.Infra.CrossCutting;

namespace API.Controllers
{
    [Route("api/v1/content/artigos")]
    [ApiController]
    public class ArtigosController : ControllerBase
    {
        [HttpPost("criar")]
        public IActionResult Post([FromBody] ArtigosModel Artigo)
        {
            try
            {
                BancoArtigos.INSERIR_NOVO_ARTIGO_NO_BANCO_DE_DADOS(Artigo.Título, Artigo.Conteúdo, TratamentoDeURL.OBTER_UMA_URL_AMIGÁVEL(Artigo.Título));
                return StatusCode(201, "Todas as alterações foram realizadas com sucesso!");
            }
            catch
            {
                return StatusCode(500, "ERRO: Um erro inesperado ocorreu com o servidor e não foi possível fazer o post.");
            }
        }

        [HttpGet("{url}")]
        public IActionResult Get(string url)
        {
            try
            {
                return StatusCode(200, "Método GET realizado com sucesso!");
            }
            catch
            {
                return StatusCode(500, "Um erro inesperado ocorreu com o servidor");
            }
        }
    }
}