using Microsoft.AspNetCore.Mvc;

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


        [Route("Home/Artigos/Visualizar/{url}")]
        public IActionResult Visualizar([FromRoute] string Url)
        {
            return View("Areas/Home/Views/Artigos/Artigo.cshtml");
        }
    }
}
