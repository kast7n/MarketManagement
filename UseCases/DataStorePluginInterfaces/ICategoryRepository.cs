using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        void UpdateCategory(int categoryId, Category category);
        IEnumerable<Category> GetCategories();
        Category? GetCategoryById(int categoryId);
        void DeleteCategory(int categoryId);
        void AddCategory(Category category);
    }
}