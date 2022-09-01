using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ServiceProductAssembly : IServiceProductAssembly
    {
        private readonly IProductAssemblyRepository _productAssembledRepository;

        public ServiceProductAssembly(IProductAssemblyRepository productAssembledRepository)
        {
            _productAssembledRepository = productAssembledRepository;
        }
        public Task AddProductAssemblyAsync(ProductAssembly productAssembled) => this._productAssembledRepository.AddProductAssembledAsync(productAssembled);
        public Task DeleteProductAssemblyAsync(ProductAssembly productAssembled) => this._productAssembledRepository.DeleteProductAssembledAsync(productAssembled);
        public Task<ICollection<ProductAssembly>> GetAllProductAssemblies() => this._productAssembledRepository.GetAllProductsAssembledAsync();
        public Task<ProductAssembly> GetByIdProductAssembly(int id)
        {
            return this._productAssembledRepository.GetByIdProducnAssembledAsyn(id);
        }

        public async Task UpdateProductAssemblyAsync(ProductAssembly productAssembled, int id)
        {
            var productAssemblyToUpdate = await this._productAssembledRepository.GetByIdProducnAssembledAsyn(id);
            if (productAssemblyToUpdate != null)
            {
                productAssemblyToUpdate.Name = productAssembled.Name;
                //productAssemblyToUpdate.PartComponent = productAssembled.PartComponent;
                productAssemblyToUpdate.TotalPrice = productAssembled.TotalPrice;
                await this._productAssembledRepository.UpdateProductAssembledAsync(productAssemblyToUpdate);
            }
        }


        public Task AddPartTo(ProductAssembly productAssembled) => this._productAssembledRepository.AddProductAssembledAsync(productAssembled);
    }
}
