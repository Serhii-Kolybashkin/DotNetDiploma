using Autofac;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using Infrastructure.DataContexts;
using Infrastructure.Repositories;
using Infrastructure.Services;

namespace ProductConfigurator.AgregationRoot
{
    public class ApplicationRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataContext>().AsSelf();
            builder.RegisterType<PartComponentRepository>().As<IPartComponentRepository>();
            builder.RegisterType<ProductAssemblyRepository>().As<IProductAssemblyRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<ServiceComponent>().As<IServiceComponent>();
            builder.RegisterType<ServiceProductAssembly>().As<IServiceProductAssembly>();
            builder.RegisterType<ServiceOrder>().As<IServiceOrder>();
        }
    }
}
