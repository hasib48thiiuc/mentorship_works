using InventoryManagement.Models.Domain;

namespace InventoryManagement.Repository
{
    public class ItemRepository:IItemRepository
    {

        private readonly ApplicationDbContext _ctx;


        public ItemRepository(ApplicationDbContext ctx)
        {
            
            _ctx= ctx;

        }
        public void AddItem(Item item)
        {

                _ctx.Items.Add(item);

       

        }
        public void SaveItem()
        {

                _ctx.SaveChanges();



        }


        public IEnumerable<Item> ShowItem()
        {
            var items = _ctx.Items.ToList();
            return items;
        }


        public Item FindItem(int id)
        {


          Item items=  _ctx.Items.Find(id);
            return items;

        }

        public void EditItem(Item item)
        {
        
  
              _ctx.Items.Update(item);

           
        }



        public void  DeleteItem(Item item)
        {

  
                    _ctx.Items.Remove(item);
        }
    }
}

    
