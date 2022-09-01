using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ServiceOrder : IServiceOrder
    {
        private readonly IOrderRepository _orderRepository;

        public ServiceOrder(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task AddOrderAsync(Order order) => this._orderRepository.AddOrderAsync(order);

        public Task DeleteOrderAsync(Order order) => this._orderRepository.DeleteOrderAsync(order);

        public Task<ICollection<Order>> GetAllOrdersAsync() => this._orderRepository.GetAllOrdersAsync();

        public Task<Order> GetByIdOrder(int id) => this._orderRepository.GetByIdOrderAsync(id);

        public async Task UpdateOrderAsync(Order order, int id)
        {
            var orderToUpdate = await this._orderRepository.GetByIdOrderAsync(id);
            if (orderToUpdate != null)
            {
                orderToUpdate.OrderNumber = order.OrderNumber;
                //orderToUpdate.PartComponents = order.PartComponents;
                orderToUpdate.Quantity = order.Quantity;
                orderToUpdate.Price = order.Price;
                await this._orderRepository.UpdateOrderAsync(orderToUpdate);
            }
        }
    }
}
