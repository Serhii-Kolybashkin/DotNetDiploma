using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using Infrastructure.DataContexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private DataContext _dataContext;

        public OrderRepository(DataContext dataContextOrders)
        {
            this._dataContext = dataContextOrders;
        }

        public async Task AddOrderAsync(Order orders)
        {
            await this._dataContext.orders.AddAsync(orders);
            await this._dataContext.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(Order orders)
        {
            this._dataContext.orders.Remove(orders);
            await this._dataContext.SaveChangesAsync();
        }

        public async Task<ICollection<Order>> GetAllOrdersAsync()
        {
            return await this._dataContext.orders.ToListAsync();
        }

        public async Task<Order> GetByIdOrderAsync(int id)
        {
            return await this._dataContext.orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateOrderAsync(Order orders)
        {
            this._dataContext.orders.Update(orders);
            await this._dataContext.SaveChangesAsync();
        }
    }
}
