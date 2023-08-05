using Autofac;
using Inven_Lib.BusinessObjects;
using Inven_Lib.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Areas.Manager.Models
{
    public class ItemCreateModel
    {
        [Required]

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        private  IItemServices _ItemServices { get; set; }
        private  ILifetimeScope _scope;

        public ItemCreateModel() 
        { 
        
        }

        internal void ResolveDependency(ILifetimeScope scope)
        {
            _scope= scope;  
            _ItemServices=_scope.Resolve<IItemServices>();
        }
        public ItemCreateModel(IItemServices itemServices)
        {
            _ItemServices = itemServices;
        }
       
        internal async Task CreateItem()
        {
            Item item = new Item();
            item.Price = Price;
             item.Name = Name;
            item.Quantity = Quantity;
            _ItemServices.CreateItem (item);
        }
        internal IEnumerable<Item> GetAllItems()
        {


            return _ItemServices.GetAllItems().Select(x => new Item { Id=x.Id, Name=x.Name, Price=x.Price,Quantity=x.Quantity });
               
        }
    }

}
