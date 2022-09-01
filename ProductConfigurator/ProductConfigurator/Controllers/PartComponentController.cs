using AutoMapper;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using ProductConfigurator.Models;
using System.Threading.Tasks;

namespace ProductConfigurator.Controllers
{
    [ApiController]
    [Route("detail")]
    public class PartComponentController : Controller
    {
        private readonly IServiceComponent _serviceComponent;
        private readonly IMapper _componentMapper;
        public PartComponentController(IServiceComponent serviceComponent, IMapper componentMapper)
        {
            _serviceComponent = serviceComponent;
            _componentMapper = componentMapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllComponents()
        {
            var components = await this._serviceComponent.GetAllComponentsAsync();
            return this.Ok(components);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var component = await this._serviceComponent.GetByIdComponent(id);
            if (component == null)
            {
                return this.NotFound();
            }
            return this.Ok(component);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateComponentsAsync([FromBody] ComponentModel componentModel)
        {
            var component = this._componentMapper.Map<PartComponent>(componentModel);
            await this._serviceComponent.AddComponentAsync(component);
            return this.Ok();
        }
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> UpdateComponentAsync([FromBody] ComponentModel componentModel, [FromRoute] int id)
        {
            var component = this._componentMapper.Map<PartComponent>(componentModel);
            await this._serviceComponent.UpdateComponentAsync(component, id);
            return this.Ok(component);
        }
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteComponentAsync([FromRoute] int id)
        {
            var component = await this._serviceComponent.GetByIdComponent(id);
            if (component != null)
            {
                await this._serviceComponent.DeleteComponentAsync(component);
                return this.Ok();
            }
            return this.NotFound();
        }
        [HttpPost("addPart")]
        public async Task<IActionResult> CreatePartTest([FromBody] ComponentModel componentModel)
        {
            var component = this._componentMapper.Map<PartComponent>(componentModel);
            await this._serviceComponent.AddComponentAsync(component);
            return this.Ok();
        }
    }
}
