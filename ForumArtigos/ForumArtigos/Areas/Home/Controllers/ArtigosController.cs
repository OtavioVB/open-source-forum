using Microsoft.AspNetCore.Mvc;

namespace ForumArtigos.Areas.Home.Controllers
{
    public class ArtigosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
