using Microsoft.AspNetCore.Mvc;

namespace DynamicPropertyViewModel.Controllers
{
  public class HomeController : Controller
  {
        public IActionResult Index()
    {
      return View();
    }
    public IActionResult CorporativeSales()
    {
      return View();
    }
    }
}
