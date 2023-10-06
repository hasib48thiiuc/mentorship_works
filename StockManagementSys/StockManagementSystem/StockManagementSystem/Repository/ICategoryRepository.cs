using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        List<Category> GetCategoryByCompany(int id);



    }
}