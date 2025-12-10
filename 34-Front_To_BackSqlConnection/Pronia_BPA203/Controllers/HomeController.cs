using Microsoft.AspNetCore.Mvc;

namespace Pronia_BPA203.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
