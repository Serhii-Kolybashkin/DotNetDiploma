using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IOrderRepository
    {
        Task<ICollection<Order>> GetAllOrdersAsync();
        Task<Order> GetByIdOrderAsync(int id);
        Task AddOrderAsync(Order orders);
        Task UpdateOrderAsync(Order orders);
        Task DeleteOrderAsync(Order orders);
    }
}
