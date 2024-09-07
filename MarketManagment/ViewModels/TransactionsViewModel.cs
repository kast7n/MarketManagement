using MarketManagment.Models;
using System.ComponentModel.DataAnnotations;

namespace MarketManagment.ViewModels
{
    public class TransactionsViewModel
    {
        public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
        public string? Cashier { get; set; } = "";
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; } = DateTime.Now;
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; } = DateTime.Now;

    }
}
