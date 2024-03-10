using Microsoft.AspNetCore.Mvc;

namespace Ressume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
