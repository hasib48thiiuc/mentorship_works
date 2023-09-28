using StockManagementSystem.BusinessObjects;

namespace StockManagementSystem.Services
{
    public interface ICategoryService
    {
        void Create(CategoryBO category);
        void Delete(int id);
        List<CategoryBO> GetAll();
        CategoryBO GetById(int id);
        void Update(CategoryBO item);
    }
}
