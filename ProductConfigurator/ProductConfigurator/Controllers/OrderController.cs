using AutoMapper;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using ProductConfigurator.Models;
using System.Threading.Tasks;

namespace ProductConfigurator.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : Controller
    {
        private readonly IServiceOrder _serviceOrder;
        private readonly IMapper _orderMapper;

        public OrderController(IServiceOrder serviceOrder, IMapper orderMapper)
        {
            _serviceOrder = serviceOrder;
            _orderMapper = orderMapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var order = await this._serviceOrder.GetAllOrdersAsync();
            return this.Ok(order);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var order = await this._serviceOrder.GetByIdOrder(id);
            if (order == null)
            {
                return this.NotFound();
            }
            return this.Ok(order);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateComponentsAsync([FromBody] OrderModel orderModel)
        {
            var order = this._orderMapper.Map<Order>(orderModel);
            await this._serviceOrder.AddOrderAsync(order);
            return this.Ok();
        }
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> UpdateComponentAsync([FromBody] OrderModel orderModel, [FromRoute] int id)
        {
            var order = this._orderMapper.Map<Order>(orderModel);
            await this._serviceOrder.UpdateOrderAsync(order, id);
            return this.Ok(order);
        }
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteComponentAsync([FromRoute] int id)
        {
            var order = await this._serviceOrder.GetByIdOrder(id);
            if (order != null)
            {
                await this._serviceOrder.DeleteOrderAsync(order);
                return this.Ok();
            }
            return this.NotFound();
        }
    }
}
