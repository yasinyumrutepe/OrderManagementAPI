using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementAPI.Application.Features.Commands.Order.CreateOrder;

namespace OrderManagementAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(CreateOrderCommandRequest createOrderCommandRequest)
        { 
            var result = await _mediator.Send(createOrderCommandRequest);
            return Ok(result);
        }
    }
}
