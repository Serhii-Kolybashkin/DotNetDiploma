using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using Infrastructure.DataContexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Infrastructure.Repositories
{
    public class ProductAssemblyRepository : IProductAssemblyRepository
    {
        private DataContext _dataContext;

        public ProductAssemblyRepository (DataContext dataContextProductAssembly)
        {
            this._dataContext = dataContextProductAssembly;
        }
        public async Task<ICollection<ProductAssembly>> GetAllProductsAssembledAsync()
        {
            return await this._dataContext.productAssembledes.Include(x=>x.PartComponents).ToListAsync();
        }
        public async Task<ProductAssembly> GetByIdProducnAssembledAsyn(int id)
        {
            return await this._dataContext.productAssembledes.Include(x=>x.PartComponents).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddProductAssembledAsync(ProductAssembly productAssembled)
        {            
            await this._dataContext.productAssembledes.AddAsync(productAssembled);
            await this._dataContext.SaveChangesAsync();
        }
        public async Task UpdateProductAssembledAsync(ProductAssembly productAssembled)
        {
            this._dataContext.productAssembledes.Update(productAssembled);
            await this._dataContext.SaveChangesAsync();
        }
        public async Task DeleteProductAssembledAsync(ProductAssembly productAssembled)
        {
            this._dataContext.productAssembledes.Remove(productAssembled);
            await this._dataContext.SaveChangesAsync();
        }

        public async Task AddPartToProduct(ProductAssembly productAssembled)
        {
            
            await _dataContext.productAssembledes.AddAsync(productAssembled);
            await this._dataContext.SaveChangesAsync();
        }
    }
}
