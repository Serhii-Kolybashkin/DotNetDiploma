using AutoMapper;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using ProductConfigurator.Models;
using System.Threading.Tasks;

namespace ProductConfigurator.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductAssemblyController : Controller
    {
        private readonly IServiceProductAssembly _serviceProductAssembled;
        private readonly IServiceComponent _serviceComponent;
        private readonly IMapper _productAssemblyMapper;

        public ProductAssemblyController(IServiceProductAssembly serviceProductAssembled, IServiceComponent serviceComponent, IMapper productAssemblyMapper)
        {
            _serviceProductAssembled = serviceProductAssembled;
            _serviceComponent = serviceComponent;
            _productAssemblyMapper = productAssemblyMapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductAssembliesAsync()
        {
            var components = await this._serviceProductAssembled.GetAllProductAssemblies();
            return this.Ok(components);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProductAssembliesAsync(int id)
        {
            var productAssembly = await this._serviceProductAssembled.GetByIdProductAssembly(id);
            if (productAssembly == null)
            {
                return this.NotFound();
            }
            return this.Ok(productAssembly);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateProductAssemblyAsync([FromBody] ProductAssemblyModel productAssemblyModel)
        {
            var producAssembly = this._productAssemblyMapper.Map<ProductAssembly>(productAssemblyModel);
            await this._serviceProductAssembled.AddProductAssemblyAsync(producAssembly);
            return this.Ok();
        }
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> UpdateProductAssemblyAsync([FromBody] ProductAssemblyModel productAssemblyModel, [FromRoute] int id)
        {
            var productAssembly = this._productAssemblyMapper.Map<ProductAssembly>(productAssemblyModel);
            await this._serviceProductAssembled.UpdateProductAssemblyAsync(productAssembly, id);
            return this.Ok(productAssembly);
        }
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteProductAssemblyAsync([FromRoute] int id)
        {
            var productAssembly = await this._serviceProductAssembled.GetByIdProductAssembly(id);
            if (productAssembly != null)
            {
                await this._serviceProductAssembled.DeleteProductAssemblyAsync(productAssembly);
                return this.Ok();
            }
            return this.NotFound();
        }
        [HttpPost("create2")]
        public async Task<IActionResult> CreateTest([FromBody] ProductAssemblyModel productAssemblyModel)
        {            
            var producAssembly = this._productAssemblyMapper.Map<ProductAssembly>(productAssemblyModel);
            var part = await _serviceComponent.GetByIdComponent(1);
            producAssembly.PartComponents.Add(part);
            await this._serviceProductAssembled.AddProductAssemblyAsync(producAssembly);
            return this.Ok();
        }
    }
}
