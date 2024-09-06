using MarketManagment.Models;

namespace MarketManagment.ViewModels
{
    public class SalesViewModel
    {
        public int SelectedCategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}
