using MarketManagment.Models;
using MarketManagment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarketManagment.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            var salesViewModel = new SalesViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };
            return View(salesViewModel);
        }
    }
}
