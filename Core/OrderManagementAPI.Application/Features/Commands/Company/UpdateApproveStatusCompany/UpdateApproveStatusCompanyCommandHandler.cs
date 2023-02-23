using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.UpdateApproveStatusCompany
{
    public class UpdateApproveStatusCompanyCommandHandler : IRequestHandler<UpdateApproveStatusCompanyCommandRequest, UpdateApproveStatusCompanyCommandResponse>
    {
        public Task<UpdateApproveStatusCompanyCommandResponse> Handle(UpdateApproveStatusCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
