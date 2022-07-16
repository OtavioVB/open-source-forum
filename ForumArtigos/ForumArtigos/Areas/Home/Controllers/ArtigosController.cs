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
    }
}
