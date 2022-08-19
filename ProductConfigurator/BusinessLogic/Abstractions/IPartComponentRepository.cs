using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IPartComponentRepository
    {
        Task<ICollection<PartComponent>> GetAllPartComponentAsync();
        Task<PartComponent> GetByIdPartComponentAsync(int id);
        Task AddPartComponentAsync(PartComponent component);
        Task UpdatePartComponentAsync(PartComponent component);
        Task DeletePartComponentAsync(PartComponent component);
    }
}
