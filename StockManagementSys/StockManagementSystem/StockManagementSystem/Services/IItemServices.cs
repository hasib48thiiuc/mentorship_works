using StockManagementSystem.BusinessObjects;
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
        //void Update(ItemBO  item);
    }
}
