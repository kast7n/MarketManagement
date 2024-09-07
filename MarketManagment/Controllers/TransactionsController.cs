using MarketManagment.Models;
using MarketManagment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace MarketManagment.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {

                TransactionsViewModel transactionsViewModel = new TransactionsViewModel();
                return View(transactionsViewModel);
        }
        public IActionResult Search(TransactionsViewModel transactionsViewModel)
        {



            var transactions = TransactionsRepository.Search(transactionsViewModel.Cashier??string.Empty,transactionsViewModel.StartDate,transactionsViewModel.EndDate);
            transactionsViewModel.Transactions = transactions;
            return View("Index",transactionsViewModel);
        }
    }
}
