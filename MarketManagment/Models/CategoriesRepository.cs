namespace MarketManagment.Models
{
    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category { CategoryID = 1, Name = "Beverage", Description = "Beverages and Drinks" },
            new Category { CategoryID = 2, Name = "Bakery", Description = "Bakery and Breakfast" },
            new Category { CategoryID = 3, Name = "Meat", Description = "Meat and BBQ" }
        };

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(x => x.CategoryID);
            category.CategoryID = maxId + 1;
            _categories.Add(category);
        }


        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryID == categoryId);
            if (category != null)
            {
                return new Category
                {
                    CategoryID = category.CategoryID,
                    Name = category.Name,
                    Description = category.Description,
                };
            }
            return null;
        }


        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryID) return;
            var categoryToUpdate = _categories.FirstOrDefault(x => x.CategoryID == categoryId);
            if(categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryID == categoryId);
            if(category != null)
            {
                _categories.Remove(category);
            }
        }

    }
}
