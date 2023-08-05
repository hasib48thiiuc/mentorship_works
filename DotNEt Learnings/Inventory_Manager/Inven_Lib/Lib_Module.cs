using Autofac;
using Inven_Lib.Entities;
using Inven_Lib.Repositories;
using Inven_Lib.Services;
using Inven_Lib.UnitOfWork;

namespace Inven_Lib
{
    public class Lib_Module : Module
    {

        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public Lib_Module(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
               .WithParameter("connectionString", _connectionString)
               .WithParameter("migrationAssemblyName", _migrationAssemblyName)
               .InstancePerLifetimeScope();


            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
            .WithParameter("connectionString", _connectionString)
            .WithParameter("migrationAssemblyName", _migrationAssemblyName)
            .InstancePerLifetimeScope();

            builder.RegisterType<ItemServices>().As<IItemServices>().
                InstancePerLifetimeScope();

            builder.RegisterType<ItemRepository>().As<IItemRepository>().
              InstancePerLifetimeScope();


            builder.RegisterType<ApplicationUnitOfWork>()
                .As<IApplicationUnitOfWork>().
              InstancePerLifetimeScope();



            base.Load(builder);
        }
    }
}
