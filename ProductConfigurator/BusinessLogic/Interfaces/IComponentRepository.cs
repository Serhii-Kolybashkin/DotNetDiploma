﻿using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IComponentRepository
    {
        Task<ICollection<PartComponent>> GetAllComponentsAsync();
        Task<PartComponent> GetByIdComponentAsync(int id);
        Task AddComponentAsync(PartComponent component);
        Task UpdateComponentAsync(PartComponent component);
        Task DeleteComponentAsync(PartComponent component);
    }
}
