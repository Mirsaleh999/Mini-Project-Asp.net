using Microsoft.AspNetCore.Mvc;

namespace Ressume.Presentation.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
