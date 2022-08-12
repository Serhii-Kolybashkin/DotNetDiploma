using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    class ServiceComponent : IServiceComponent
    {
        private readonly IComponentRepository _componentRepository;

        public ServiceComponent(IComponentRepository componentRepository)
        {
            _componentRepository = componentRepository;
        }

        public Task AddComponentAsync(Component component) => this._componentRepository.AddComponentAsync(component);
        public Task DeleteComponentAsync(Component component) => this._componentRepository.DeleteComponentAsync(component);
        public Task<ICollection<Component>> GetAllComponentsAsync() => this._componentRepository.GetAllComponentsAsync();
        public Task<Component> GetByIdComponent(int id) => this._componentRepository.GetByIdComponentAsync(id);
        public Task UpdateComponentAsync(Component component) => this.UpdateComponentAsync(component);
    }
}
