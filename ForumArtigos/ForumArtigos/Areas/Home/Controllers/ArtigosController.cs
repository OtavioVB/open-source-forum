using Microsoft.AspNetCore.Mvc;
using ForumArtigos.Areas.Home.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace ForumArtigos.Areas.Home.Controllers
{
    [Area("Home")]
    public class ArtigosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enviar(ArtigoModel Artigo)
        {
            Task Resposta = Post(Artigo);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task Post(ArtigoModel Artigo)
        {
            HttpClient client = new HttpClient() { BaseAddress = new Uri("https://localhost:7123/api/v1/content/artigos/criar") };
            HttpResponseMessage response = await client.PostAsync(client.BaseAddress.ToString(), new StringContent(JsonConvert.SerializeObject(Artigo), Encoding.UTF8, "application/json"));
        }

        [Route("Home/Artigos/Visualizar/{url}")]
        public IActionResult Visualizar([FromRoute] string Url)
        {
            TempData["ARTIGO_IDENTIFICADOR"] = Url;
            return View("Areas/Home/Views/Artigos/Artigo.cshtml");
        }
    }
}
