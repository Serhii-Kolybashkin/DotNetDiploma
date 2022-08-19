using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using Infrastructure.DataContexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PartComponentRepository : IPartComponentRepository
    {
        private DataContext _dataContext;

        public PartComponentRepository (DataContext dataContextComponents)
        {
            this._dataContext = dataContextComponents;
        }
        public async Task<ICollection<PartComponent>> GetAllPartComponentAsync()
        {
            return await this._dataContext.components.ToListAsync();
        }
        public async Task<PartComponent> GetByIdPartComponentAsync(int id)
        {
            return await this._dataContext.components.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddPartComponentAsync(PartComponent component)
        {
            await this._dataContext.components.AddAsync(component);
            await this._dataContext.SaveChangesAsync();
        }
        public async Task UpdatePartComponentAsync(PartComponent component)
        {
            this._dataContext.components.Update(component);
            await this._dataContext.SaveChangesAsync();
        }        
        public async Task DeletePartComponentAsync(PartComponent component)
        {
            this._dataContext.components.Remove(component);
            await this._dataContext.SaveChangesAsync();
        }
    }
}
