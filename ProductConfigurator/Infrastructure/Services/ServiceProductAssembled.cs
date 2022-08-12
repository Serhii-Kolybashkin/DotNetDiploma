using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    class ServiceProductAssembled : IServiceProductAssembled
    {
        private readonly IProductAssembledRepository _productAssembledRepository;

        public ServiceProductAssembled(IProductAssembledRepository productAssembledRepository)
        {
            _productAssembledRepository = productAssembledRepository;
        }
        public Task AddComponentAsync(ProductAssembled productAssembled) => this._productAssembledRepository.AddProductAssembledAsync(productAssembled);
        public Task DeleteComponentAsync(ProductAssembled productAssembled) => this._productAssembledRepository.DeleteProductAssembledAsync(productAssembled);
        public Task<ICollection<ProductAssembled>> GetAllComponentsAsync() => this._productAssembledRepository.GetAllProductsAssembledAsync();
        public Task<ProductAssembled> GetByIdComponent(int id) => this._productAssembledRepository.GetByIdProducnAssembledAsyn(id);
        public Task UpdateComponentAsync(ProductAssembled productAssembled) => this._productAssembledRepository.UpdateProductAssembledAsync(productAssembled);
    }
}
