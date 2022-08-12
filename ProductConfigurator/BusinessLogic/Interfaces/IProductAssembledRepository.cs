using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductAssembledRepository
    {
        Task<ICollection<ProductAssembled>> GetAllProductsAssembledAsync();
        Task<ProductAssembled> GetByIdProducnAssembledAsyn(int id);
        Task AddProductAssembledAsync(ProductAssembled productAssembled);
        Task UpdateProductAssembledAsync(ProductAssembled productAssembled);
        Task DeleteProductAssembledAsync(ProductAssembled productAssembled);
    }
}
