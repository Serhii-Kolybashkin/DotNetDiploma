using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ServiceComponent : IServiceComponent
    {
        private readonly IPartComponentRepository _componentRepository;

        public ServiceComponent(IPartComponentRepository componentRepository)
        {
            _componentRepository = componentRepository;
        }

        public Task AddComponentAsync(PartComponent component) => this._componentRepository.AddPartComponentAsync(component);
        public Task DeleteComponentAsync(PartComponent component) => this._componentRepository.DeletePartComponentAsync(component);
        public Task<ICollection<PartComponent>> GetAllComponentsAsync() => this._componentRepository.GetAllPartComponentAsync();
        public Task<PartComponent> GetByIdComponent(int id) => this._componentRepository.GetByIdPartComponentAsync(id);
        public async Task UpdateComponentAsync(PartComponent component, int id)
        {
            var componentToUpdate = await this._componentRepository.GetByIdPartComponentAsync(id);
            if (componentToUpdate != null)
            {
                componentToUpdate.Name = component.Name;
                componentToUpdate.Price = component.Price;
                componentToUpdate.Quantity = component.Quantity;
                await this._componentRepository.UpdatePartComponentAsync(componentToUpdate);
            }
        }
    }
}
