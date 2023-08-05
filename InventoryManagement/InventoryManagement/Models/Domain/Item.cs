using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models.Domain
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        
        public string Name { get; set; }

        [Required]
        
        public int Quantity { get; set; }


    }
}
