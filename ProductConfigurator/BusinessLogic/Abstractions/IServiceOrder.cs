using BusinessLogic.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces.Services
{
    public interface IServiceOrder
    {
        Task<ICollection<Order>> GetAllOrdersAsync();
        Task<Order> GetByIdOrder(int id);
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order, int id);
        Task DeleteOrderAsync(Order order);
    }
}
