using StockManagementSystem.BusinessObjects;

namespace StockManagementSystem.Services
{
    public interface ISoldItemsService
    {
        void Create(List<SoldItemsBO> item);
    }
}