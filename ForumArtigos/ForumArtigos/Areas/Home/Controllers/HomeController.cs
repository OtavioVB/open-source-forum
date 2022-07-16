using Microsoft.AspNetCore.Mvc;

namespace ForumArtigos.Areas.Home.Controllers
{
    [Area("Home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
