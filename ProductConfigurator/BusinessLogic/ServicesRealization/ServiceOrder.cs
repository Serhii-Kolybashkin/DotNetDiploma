using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    class ServiceOrder : IServiceOrder
    {
        private readonly IOrderRepository _orderRepository;

        public ServiceOrder(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task AddComponentAsync(Order order) => this._orderRepository.AddComponentAsync(order);

        public Task DeleteComponentAsync(Order order) => this._orderRepository.DeleteComponentAsync(order);

        public Task<ICollection<Order>> GetAllComponentsAsync() => this.GetAllComponentsAsync();

        public Task<Order> GetByIdComponent(int id) => this._orderRepository.GetByIdComponentAsync(id);

        public Task UpdateComponentAsync(Order order) => this._orderRepository.UpdateComponentAsync(order);
    }
}
