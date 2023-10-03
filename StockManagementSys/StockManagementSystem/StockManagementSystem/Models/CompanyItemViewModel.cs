using AutoMapper;
using StockManagementSystem.Models.Domain;
using StockManagementSystem.Services;
using System.ComponentModel.DataAnnotations;

namespace StockManagementSystem.Models
{
    public class CompanyItemViewModel
    {
      
        public IEnumerable<Company>? Companies { get; set; }
        public IEnumerable<Item>? Items { get; set; } 
        public Item? SelectedItem { get; set; } = new Item();
        public int QuantityToChange { get; set; }

        public int SelectedCompanyId { get; set; }
        public int SelectedItemId { get; set; }
        

    }
}
