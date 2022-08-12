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
        Task<ICollection<Order>> GetAllComponentsAsync();
        Task<Order> GetByIdComponentAsync(int id);
        Task AddComponentAsync(Order orders);
        Task UpdateComponentAsync(Order orders);
        Task DeleteComponentAsync(Order orders);
    }
}
