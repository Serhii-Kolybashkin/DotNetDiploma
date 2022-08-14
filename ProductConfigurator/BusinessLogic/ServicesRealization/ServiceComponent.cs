using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ServiceComponent : IServiceComponent
    {
        private readonly IComponentRepository _componentRepository;

        public ServiceComponent(IComponentRepository componentRepository)
        {
            _componentRepository = componentRepository;
        }

        public Task AddComponentAsync(PartComponent component) => this._componentRepository.AddComponentAsync(component);
        public Task DeleteComponentAsync(PartComponent component) => this._componentRepository.DeleteComponentAsync(component);
        public Task<ICollection<PartComponent>> GetAllComponentsAsync() => this._componentRepository.GetAllComponentsAsync();
        public Task<PartComponent> GetByIdComponent(int id) => this._componentRepository.GetByIdComponentAsync(id);
        public Task UpdateComponentAsync(PartComponent component) => this.UpdateComponentAsync(component);
    }
}
