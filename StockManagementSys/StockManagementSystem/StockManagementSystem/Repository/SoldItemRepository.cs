using StockManagementSystem.Models.Domain;
using System.Globalization;

namespace StockManagementSystem.Repository
{
    public class SoldItemRepository:Repository<StockOutItem>,ISoldItemRepository
    {
        public SoldItemRepository(ApplicationDbContext ctx): base(ctx) 
        { 
        
        }

        public List<StockOutItem> SearchByDate(DateTime fromdate, DateTime Todate)
        {




            List<StockOutItem> Items = _ctx.Solditems.Where((item => item.date >= fromdate
            && item.date <= Todate && item.StockOutType==StockOutType.Sell ) )
         .ToList();


            return Items; // 
        }


    }
}
