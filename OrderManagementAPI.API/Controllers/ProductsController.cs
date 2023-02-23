using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementAPI.Application.Features.Commands.Product.CreateProduct;
using OrderManagementAPI.Application.Repositories;

namespace OrderManagementAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

       

        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductCommandRequest createProductCommandRequest)
        {   
            var result =await  _mediator.Send(createProductCommandRequest);
            return Ok(result);
        }
    }
}
