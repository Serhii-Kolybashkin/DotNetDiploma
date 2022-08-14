using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using Infrastructure.DataContexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ComponentRepository : IComponentRepository
    {
        private DataContext _dataContext;

        public ComponentRepository (DataContext dataContextComponents)
        {
            this._dataContext = dataContextComponents;
        }
        public async Task<ICollection<PartComponent>> GetAllComponentsAsync()
        {
            return await this._dataContext.components.ToListAsync();
        }
        public async Task<PartComponent> GetByIdComponentAsync(int id)
        {
            return await this._dataContext.components.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddComponentAsync(PartComponent component)
        {
            await this._dataContext.components.AddAsync(component);
            await this._dataContext.SaveChangesAsync();
        }
        public async Task UpdateComponentAsync(PartComponent component)
        {
            this._dataContext.components.Update(component);
            await this._dataContext.SaveChangesAsync();
        }        
        public async Task DeleteComponentAsync(PartComponent component)
        {
            this._dataContext.components.Remove(component);
            await this._dataContext.SaveChangesAsync();
        }
    }
}
