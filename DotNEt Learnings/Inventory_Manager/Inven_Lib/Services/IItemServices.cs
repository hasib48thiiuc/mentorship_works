using ItemBO = Inven_Lib.BusinessObjects.Item;
using ItemEO = Inven_Lib.Entities.Item;
namespace Inven_Lib.Services
{
    public interface IItemServices
    {
        IEnumerable<ItemEO> GetAllItems();
        void CreateItem(ItemBO item);

        public (int total, int totalDisplay, IList<ItemBO> records) GetItems(int pageIndex,
            int pageSize, string searchText, string orderby);
        //object GetItems(object pageIndex, object pageSize, object searchText, object value);
    }
}