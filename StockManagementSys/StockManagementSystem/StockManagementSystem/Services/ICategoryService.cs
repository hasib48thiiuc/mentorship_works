using StockManagementSystem.BusinessObjects;

namespace StockManagementSystem.Services
{
    public interface ICategoryService
    {
        void Create(CategoryBO category);
        void Add(CategoryBO item);
        void Delete(int id);
        IEnumerable<CategoryBO> GetAll();
        CategoryBO GetById(int id);
        void Update(CategoryBO item);
    }
}
