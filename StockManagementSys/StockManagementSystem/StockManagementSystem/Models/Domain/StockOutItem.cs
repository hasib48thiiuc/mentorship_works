namespace StockManagementSystem.Models.Domain
{
    public class StockOutItem
    {


        public int Id { get; set; }
        public int ItemId{ get; set; }

        
        public String ItemName { get; set; }
        public String CompanyName{get; set; }


        public int QuantityToChange { get;set; }


        public DateTime date { get; set; }

        public StockOutType StockOutType { get; set; }
    }

    
    public enum StockOutType
    {
        Sell=1,
        Damage=2,
        Lost=3
    }
}
