using Autofac;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using Infrastructure.DataContexts;
using Infrastructure.Repositories;
using Infrastructure.Services;

namespace ProductConfigurator.AgregationRoot
{
    public class AggregationTest : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ComponentRepository>().As<IComponentRepository>();
            builder.RegisterType<DataContext>().AsSelf();
            builder.RegisterType<ServiceComponent>().As<IServiceComponent>();
        }
    }
}
