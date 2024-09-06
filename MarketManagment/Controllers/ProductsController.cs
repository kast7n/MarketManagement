using Microsoft.AspNetCore.Mvc;
using MarketManagment.Models;
using MarketManagment.ViewModels;
namespace MarketManagment.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductsRepository.GetProducts(loadCategory:true);
            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "edit";
            var productViewModel = new ProductViewModel
            {
                Product = ProductsRepository.GetProductById(id)??new Product(),
                Categories = CategoriesRepository.GetCategories()
            };
            
 
            
            return View(productViewModel);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                ProductsRepository.UpdateProduct(productViewModel.Product.ProductId, productViewModel.Product);
                return RedirectToAction(nameof(Index));
            }

            return View(productViewModel);
        }


        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "add";
            var productViewModel = new ProductViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };
            return View(productViewModel);
        }
        [HttpPost]
        public IActionResult Add(ProductViewModel productvm)
        {
            if (ModelState.IsValid)
            {
                ProductsRepository.AddProduct(productvm.Product);
                return RedirectToAction(nameof(Index));
            }
            productvm.Categories = CategoriesRepository.GetCategories();
            return View(productvm);
        }


        public IActionResult Delete(int productId)
        {
            ProductsRepository.DeleteProduct(productId);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ProductsByCategoryPartial(int categoryId)
        {
            var products = ProductsRepository.GetProductsByCategoryId(categoryId);

            return PartialView("_Products", products);
        }
    }
}
