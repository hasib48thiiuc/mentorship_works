using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public interface ISoldItemRepository:IRepository<StockOutItem>
    {
        List<StockOutItem> SearchByDate(DateTime fromdate, DateTime Todate);


    }
}
