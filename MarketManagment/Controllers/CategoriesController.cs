using Microsoft.AspNetCore.Mvc;
using MarketManagment.Models;
namespace MarketManagment.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }
        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryID=id.HasValue ? id.Value : 0 ,Name="cookies"};

            return View(category);
        }
    }
}
