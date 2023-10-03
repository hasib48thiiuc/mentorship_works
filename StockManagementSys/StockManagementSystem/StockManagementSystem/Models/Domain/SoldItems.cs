namespace StockManagementSystem.Models.Domain
{
    public class SoldItems
    {

        public int Id { get; set; }
        public int ItemId{ get; set; }

        
        public Item item { get; set; }

         public int Sale_Quantity { get;set; }


        public DateTime date { get; set; } 

    }
}
