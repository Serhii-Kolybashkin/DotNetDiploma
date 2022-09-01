using AutoMapper;
using BusinessLogic.Entities;
using ProductConfigurator.Models;

namespace ProductConfigurator.MappingProfiles
{
    public class DIMappingProfiles : Profile
    {
        public DIMappingProfiles()
        {
            this.CreateMap<PartComponent, ComponentModel>();
            this.CreateMap<ComponentModel, PartComponent>();
            this.CreateMap<Order, OrderModel>();
            this.CreateMap<OrderModel, Order>();
            this.CreateMap<ProductAssembly, ProductAssemblyModel>();
            this.CreateMap<ProductAssemblyModel, ProductAssembly>();
        }
    }
}
