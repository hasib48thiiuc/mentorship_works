using StockManagementSystem.BusinessObjects;

namespace StockManagementSystem.Services
{
    public interface ICategoryService
    {
        void Create(CategoryBO category);
        object? GetAll();
    }
}
