namespace StockManagementSystem.BusinessObjects;

    public class ItemBO
    {
        
        public int Id { get; set; }

        
        public string? Name { get; set; }

        public int? Quantity { get; set; }
     
        public int CategoryId  { get; set; }

        public CategoryBO? Category { get; set; }

        public int CompanyID { get; set; }

        public CompanyBO? Company { get; set; }

        public int ReOrderLevel { get; set; }
    }

