using Autofac;
using InventoryManager.Areas.Manager.Models;

namespace InventoryManager
{
    public class Inven_Module: Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ItemCreateModel>().AsSelf();

            builder.RegisterType<ItemListModel>().AsSelf();


            base.Load(builder);
        }
    }
}
