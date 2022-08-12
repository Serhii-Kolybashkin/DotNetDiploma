using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces.Services
{
    public interface IServiceProductAssembled
    {
        Task<ICollection<ProductAssembled>> GetAllComponentsAsync();
        Task<ProductAssembled> GetByIdComponent(int id);
        Task AddComponentAsync(ProductAssembled productAssembled);
        Task UpdateComponentAsync(ProductAssembled productAssembled);
        Task DeleteComponentAsync(ProductAssembled productAssembled);
    }
}
