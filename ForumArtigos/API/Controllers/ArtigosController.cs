using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models.Content;
using API.Data.BancoArtigos;

namespace API.Controllers
{
    [Route("api/v1/content/artigos")]
    [ApiController]
    public class ArtigosController : ControllerBase
    {
        [HttpPost("criar")]
        public IActionResult Post([FromBody] ArtigosModel Artigo)
        {
            if (BancoArtigos.TESTE())
            {
                return StatusCode(200);
            }
            return StatusCode(404);
        }
    }
}
