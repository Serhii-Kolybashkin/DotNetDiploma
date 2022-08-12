using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using Infrastructure.DataContexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Infrastructure.Repositories
{
    public class ProductAssembledRepository : IProductAssembledRepository
    {
        private DataContext _dataContext;

        public ProductAssembledRepository (DataContext dataContextProductAssembled)
        {
            this._dataContext = dataContextProductAssembled;
        }
        public async Task<ICollection<ProductAssembled>> GetAllProductsAssembledAsync()
        {
            return await this._dataContext.productAssembledes.ToListAsync();
        }
        public async Task<ProductAssembled> GetByIdProducnAssembledAsyn(int id)
        {
            return await this._dataContext.productAssembledes.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddProductAssembledAsync(ProductAssembled productAssembled)
        {
            await this._dataContext.productAssembledes.AddAsync(productAssembled);
            await this._dataContext.SaveChangesAsync();
        }
        public async Task UpdateProductAssembledAsync(ProductAssembled productAssembled)
        {
            this._dataContext.productAssembledes.Update(productAssembled);
            await this._dataContext.SaveChangesAsync();
        }
        public async Task DeleteProductAssembledAsync(ProductAssembled productAssembled)
        {
            this._dataContext.productAssembledes.Remove(productAssembled);
            await this._dataContext.SaveChangesAsync();
        }
    }
}
