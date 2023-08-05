using Autofac;
using FirstDemo.Web.Models;
using Inven_Lib.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventoryManager.Areas.Manager.Models
{
    public class ItemListModel
    {
        private IItemServices? _ItemServices { get; set; }
        private ILifetimeScope _scope;

   

        internal void ResolveDependency(ILifetimeScope scope)
        {
            _scope = scope;
            _ItemServices = _scope.Resolve<IItemServices>();
        }
        public ItemListModel(IItemServices itemServices)
        {
            _ItemServices = itemServices;
        }


        internal object? GetPagedItems(DataTablesAjaxRequestModel model)
        {
            var data=_ItemServices?.GetItems(
                model.PageIndex,
                model.PageSize,
                model.SearchText,
                model.GetSortText(new string[] { "Name", "Price", "Quantity" }));

            return new
            {
                recordsTotal = data?.total,
                recordsFiltered = data?.totalDisplay,
                data = (from record in data?.records
                        select new string[]
                        {
                                record.Name,
                                record.Price.ToString(),
                                record.Quantity.ToString(),
                                record.Id.ToString()
                        }
                    ).ToArray()
            };
        }
    }
}
