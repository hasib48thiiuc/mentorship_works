using Autofac;
using StockManagementSystem.Models;
using System.Reflection;

namespace StockManagementSystem
{
    public class WebModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegisterModel>().AsSelf();
           builder.RegisterType<LoginModel>().AsSelf();

            base.Load(builder);
        }
    }
}
