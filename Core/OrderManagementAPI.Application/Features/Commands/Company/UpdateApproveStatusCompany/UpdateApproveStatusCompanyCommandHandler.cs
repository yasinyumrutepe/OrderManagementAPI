using MediatR;
using OrderManagementAPI.Application.Repositories;
using OrderManagementAPI.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.UpdateApproveStatusCompany
{
    public class UpdateApproveStatusCompanyCommandHandler : IRequestHandler<UpdateApproveStatusCompanyCommandRequest, UpdateApproveStatusCompanyCommandResponse>
    {
        readonly ICompanyReadRepository _companyreadRepository;
        readonly ICompanyWriteRepository _companywriteRepository;

        public UpdateApproveStatusCompanyCommandHandler(ICompanyReadRepository companyreadRepository, ICompanyWriteRepository companywriteRepository)
        {
            _companyreadRepository = companyreadRepository;
            _companywriteRepository = companywriteRepository;
        }

        public async Task<UpdateApproveStatusCompanyCommandResponse> Handle(UpdateApproveStatusCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            
           var com= await _companyreadRepository.GetByIdAsync(request.Id);
            if(com == null)
            {
                return new()
                {
                    Message = "Company Not Found ",
                    IsUpdate = false
                };
            }


            bool status = !com.ApprovelStatus;
            com.ApprovelStatus = status;

            var result = _companywriteRepository.Update(com);
           await _companywriteRepository.SaveAsync();
            return new()
            {
                Model=com,
                IsUpdate = result,
                
                Message=result ? "Update Succesfully" : "Update Error",
            };

        }
    }
}
