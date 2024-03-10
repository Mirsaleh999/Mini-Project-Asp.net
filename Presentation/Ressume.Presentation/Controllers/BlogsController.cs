using Microsoft.AspNetCore.Mvc;

namespace Ressume.Presentation.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
