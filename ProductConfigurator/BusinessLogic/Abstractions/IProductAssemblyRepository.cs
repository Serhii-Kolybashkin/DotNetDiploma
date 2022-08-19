using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductAssemblyRepository
    {
        Task<ICollection<ProductAssembly>> GetAllProductsAssembledAsync();
        Task<ProductAssembly> GetByIdProducnAssembledAsyn(int id);
        Task AddProductAssembledAsync(ProductAssembly productAssembled);
        Task UpdateProductAssembledAsync(ProductAssembly productAssembled);
        Task DeleteProductAssembledAsync(ProductAssembly productAssembled);
    }
}
