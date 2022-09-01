using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces.Services
{
    public interface IServiceProductAssembly
    {
        Task<ICollection<ProductAssembly>> GetAllProductAssemblies();
        Task<ProductAssembly> GetByIdProductAssembly(int id);
        Task AddProductAssemblyAsync(ProductAssembly productAssembled);
        Task UpdateProductAssemblyAsync(ProductAssembly productAssembled, int id);
        Task DeleteProductAssemblyAsync(ProductAssembly productAssembled);
        Task AddPartTo(ProductAssembly productAssembled);
    }
}
