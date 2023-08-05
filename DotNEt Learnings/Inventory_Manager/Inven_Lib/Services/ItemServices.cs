using Inven_Lib.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemBO = Inven_Lib.BusinessObjects.Item;
using ItemEO = Inven_Lib.Entities.Item;
namespace Inven_Lib.Services
{
    public class ItemServices : IItemServices
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public ItemServices(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }
        public void CreateItem(ItemBO item)
        {
            ItemEO itementity = new ItemEO();
            itementity.Name = item.Name;
            itementity.Price = item.Price;
            itementity.Quantity = item.Quantity;

            _applicationUnitOfWork.Items.Add(itementity);
            _applicationUnitOfWork.Save();

        }

        public IEnumerable<ItemEO> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public (int total, int totalDisplay, IList<ItemBO> records) GetItems(int pageIndex,
             int pageSize, string searchText, string orderby)
        {
            (IList<ItemEO> data, int total, int totalDisplay) results = _applicationUnitOfWork
                .Items.GetDynamic(x => x.Name.Contains(searchText), orderby,
                "Topics,CourseStudents", pageIndex, pageSize, true);

            IList<ItemBO> Items = new List<ItemBO>();
            foreach (ItemEO ItemEO in results.data)
            {
                Items.Add(new ItemBO
                {
                    Id = ItemEO.Id,
                    Name = ItemEO.Name, 
                     Price= ItemEO.Price,
                    Quantity = ItemEO.Quantity
                });
            }

            return (results.total, results.totalDisplay, Items);
        }
        /*public IEnumerable<ItemEO> GetAllItems()
{


  return  _applicationUnitOfWork.Items.GetAll();



}*/

    }
}

