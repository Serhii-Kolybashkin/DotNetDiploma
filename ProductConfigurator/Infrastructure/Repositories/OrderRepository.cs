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

        public async Task AddComponentAsync(Order orders)
        {
            await this._dataContext.orders.AddAsync(orders);
            await this._dataContext.SaveChangesAsync();
        }

        public async Task DeleteComponentAsync(Order orders)
        {
            this._dataContext.orders.Remove(orders);
            await this._dataContext.SaveChangesAsync();
        }

        public async Task<ICollection<Order>> GetAllComponentsAsync()
        {
            return await this._dataContext.orders.ToListAsync();
        }

        public async Task<Order> GetByIdComponentAsync(int id)
        {
            return await this._dataContext.orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateComponentAsync(Order orders)
        {
            this._dataContext.orders.Update(orders);
            await this._dataContext.SaveChangesAsync();
        }
    }
}
