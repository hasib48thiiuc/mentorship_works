namespace StockManagementSystem.Models.Domain
{
    public class Company
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Item>? Items { get; set; }

    }
}
