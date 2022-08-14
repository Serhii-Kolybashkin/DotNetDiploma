using AutoMapper;
using BusinessLogic.Entities;
using ProductConfigurator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductConfigurator.MappingProfiles
{
    public class DIMappingProfiles : Profile
    {
        public DIMappingProfiles()
        {
            this.CreateMap<PartComponent, ComponentModel>();
            this.CreateMap<ComponentModel, PartComponent>();
        }
    }
}
