using Microsoft.AspNetCore.Mvc;

namespace MarketManagment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
