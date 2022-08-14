using BusinessLogic.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces.Services
{
    public interface IServiceOrder
    {
        Task<ICollection<Order>> GetAllComponentsAsync();
        Task<Order> GetByIdComponent(int id);
        Task AddComponentAsync(Order order);
        Task UpdateComponentAsync(Order order);
        Task DeleteComponentAsync(Order order);
    }
}
