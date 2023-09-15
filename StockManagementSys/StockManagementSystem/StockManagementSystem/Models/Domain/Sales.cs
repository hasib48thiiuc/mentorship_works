namespace StockManagementSystem.Models.Domain
{
    public class Sales
    {
        public int Id { get; set; } 

        public DateTime  SaleDate { get; set; }

        public List<Item> items { get; set; }


    }
}
