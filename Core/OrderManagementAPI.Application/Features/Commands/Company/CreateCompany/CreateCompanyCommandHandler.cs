using MediatR;
using OrderManagementAPI.Application.Repositories;
using OrderManagementAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommandRequest, CreateCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;

        public CreateCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository)
        {
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {

            var company = new Domain.Entities.Company();

            company.CompanyName = request.CompanyName;
            company.ApprovelStatus = request.ApprovelStatus;
            company.OrderRelaseStartTime = request.OrderRelaseStartTime;
            company.OrderRelaseEndTime = request.OrderRelaseEndTime;
            company.ApprovelStatus = request.ApprovelStatus;

            var newcompany = await _companyWriteRepository.AddAsync(company);
            var result = new CreateCompanyCommandResponse{
               CompanyName =newcompany.CompanyName,
               ApprovelStatus=newcompany.ApprovelStatus,
               Id= newcompany.Id,
               OrderRelaseEndTime = newcompany.OrderRelaseEndTime,
               OrderRelaseStartTime = newcompany.OrderRelaseStartTime

            };
            await _companyWriteRepository.SaveAsync();
            return result;
        }
    }
}
