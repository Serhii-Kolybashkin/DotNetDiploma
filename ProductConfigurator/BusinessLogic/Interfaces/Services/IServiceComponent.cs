using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces.Services
{
    public interface IServiceComponent
    {
        Task<ICollection<Component>> GetAllComponentsAsync();
        Task<Component> GetByIdComponent(int id);
        Task AddComponentAsync(Component component);
        Task UpdateComponentAsync(Component component);
        Task DeleteComponentAsync(Component component);
    }
}
