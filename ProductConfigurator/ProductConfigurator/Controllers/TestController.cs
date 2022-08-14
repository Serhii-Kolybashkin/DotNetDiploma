using AutoMapper;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using ProductConfigurator.Models;
using System.Threading.Tasks;

namespace ProductConfigurator.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : Controller
    {
        private readonly IServiceComponent _serviceComponent;
        private readonly IMapper _componentMapper;

        public TestController(IServiceComponent serviceComponent, IMapper componentMapper)
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
        [HttpPost("create")]
        public async Task<IActionResult> CreateComponentsAsync([FromBody] ComponentModel componentModel)
        {
            var component = this._componentMapper.Map<PartComponent>(componentModel);
            await this._serviceComponent.AddComponentAsync(component);
            return this.Ok();
        }
    }
}
