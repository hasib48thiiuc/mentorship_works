using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Schema;


namespace StockManagementSystem.Models.Domain
{
    public class Item
    {
        public int Id { get; set; }

        
        public string? Name { get; set; }

        public int? Quantity { get; set; }

        public int CategoryId  { get; set; }

        public Category? Category { get; set; }

        public int CompanyID { get; set; }

        public Company? Company { get; set; }

        public int ReOrderLevel { get; set; }
    }
}
