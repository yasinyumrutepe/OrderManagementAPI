using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementAPI.Application.Features.Commands.Company.CreateCompany;
using OrderManagementAPI.Application.Features.Queries.Company.GetAllCompany;
using OrderManagementAPI.Application.Repositories;
using OrderManagementAPI.Domain.Entities;

namespace OrderManagementAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {   
        readonly private ICompanyWriteRepository _companyWriteRepository;
        readonly private ICompanyReadRepository _companyReadRepository;
        readonly IMediator _mediator;
        public CompaniesController(ICompanyWriteRepository companyWriteRepository, ICompanyReadRepository companyReadRepository, IMediator mediator, IMapper mapper)
        {
            _companyWriteRepository = companyWriteRepository;
            _companyReadRepository = companyReadRepository;
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
        [HttpPut("approve-status/{id}")]
        public async Task<IActionResult> UpdateApproveStatusCompany(int id)
        {   
               var company = await _companyReadRepository.GetByIdAsync(id);
                if(company == null)
            {
                return BadRequest("Company Not Found");
            }

            return Ok(id);



        }
        [HttpPut("order-time/{id}")]
        public async Task<IActionResult> UpdateOrderTimeCompany(int id)
        {
            if (id == 0)
            {
                return BadRequest("Id Required");
            }

            var c = await _companyReadRepository.GetByIdAsync(id);

            if (c == null)
            {
                return NotFound();

            }

            var newcompany = _companyWriteRepository.Update(c);
            await _companyWriteRepository.SaveAsync();

            return Ok(newcompany);
        }
    }
}
