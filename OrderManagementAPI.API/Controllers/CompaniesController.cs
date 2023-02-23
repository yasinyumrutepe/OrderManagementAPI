using AutoMapper;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementAPI.Application.Features.Commands.Company.CreateCompany;
using OrderManagementAPI.Application.Features.Commands.Company.UpdateApproveStatusCompany;
using OrderManagementAPI.Application.Features.Commands.Company.UpdateOrderTimeCompany;
using OrderManagementAPI.Application.Features.Queries.Company.GetAllCompany;
using OrderManagementAPI.Application.Repositories;
using OrderManagementAPI.Domain.Entities;

namespace OrderManagementAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {   
      
        readonly IMediator _mediator;
        public CompaniesController(ICompanyWriteRepository companyWriteRepository, ICompanyReadRepository companyReadRepository, IMediator mediator, IMapper mapper)
        {
         
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCompany(GetAllCompanyQueryRequest getAllCompanyQueryRequest)
        {
           var response = await _mediator.Send(getAllCompanyQueryRequest);
            
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddCompany(CreateCompanyCommandRequest createCompanyCommandRequest)
        {

            var response = await _mediator.Send(createCompanyCommandRequest);
            return Ok(response);
          


        }
        [HttpPut("approve-status")]
        public async Task<IActionResult> UpdateApproveStatusCompany(UpdateApproveStatusCompanyCommandRequest updateApproveStatusCompanyCommandRequest)
        {   
            var response = await _mediator.Send(updateApproveStatusCompanyCommandRequest);
            if (response.IsUpdate)
            {
                return Ok(response);

            }else
            {
                return BadRequest(response.Message);
            }

        }
        [HttpPut("order-time")]
        public async Task<IActionResult> UpdateOrderTimeCompany(UpdateOrderTimeCompanyCommandRequest updateOrderTimeCompanyCommandRequest)
        {

            var response = await _mediator.Send(updateOrderTimeCompanyCommandRequest);
           

            return Ok(response);
        }
    }
}
