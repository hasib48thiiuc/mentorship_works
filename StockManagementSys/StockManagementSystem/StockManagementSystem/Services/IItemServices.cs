using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.UnitOfWorks;

namespace StockManagementSystem.Services
{
    public interface IItemServices
    {
        void Create(ItemBO item);
      //  void Delete(int id);
        List<ItemBO> GetAll();
        List<ItemBO> GetItemsByCompanyId(int companyId);
        ItemBO GetById(int id);
        void UpdateItemQuantity(int id, int quantity);
        List<CategoryBO> FindCategory(int id);
        void DeleteQuantity(List<StockOutItemBO> items);
        //void Update(ItemBO  item);
    }
}
