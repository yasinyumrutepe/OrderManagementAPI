using MediatR;
using OrderManagementAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OrderManagementAPI.Domain.Entities;

namespace OrderManagementAPI.Application.Features.Queries.Company.GetAllCompany
{
    public class GetAllCompanyQueryHandler:IRequestHandler<GetAllCompanyQueryRequest,GetAllCompanyQueryResponse>
    {
        private readonly ICompanyReadRepository _companyReadRepository;
        private readonly IMapper _mapper;
        public GetAllCompanyQueryHandler(ICompanyReadRepository companyReadRepository, IMapper mapper)
        {
            _companyReadRepository = companyReadRepository;
            _mapper = mapper;
        }

        public Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            var result = _companyReadRepository.GetAll();
            return _mapper.Map<List<GetAllCompanyQueryResponse>>(result);
        }
    }
}
