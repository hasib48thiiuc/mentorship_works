using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Services
{
    public interface IStockOutItemService
    {
        void Create(List<StockOutItemBO> item);
        public List<StockOutItemBO> GetAll();
        public List<StockOutItem> GetItemQuantity(DateTime formattedDate, DateTime formattedDate2);
    }
}