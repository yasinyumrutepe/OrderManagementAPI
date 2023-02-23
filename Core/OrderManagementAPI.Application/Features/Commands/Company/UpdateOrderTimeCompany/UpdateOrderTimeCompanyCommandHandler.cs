using MediatR;
using Microsoft.VisualBasic;
using OrderManagementAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.UpdateOrderTimeCompany
{
    public class UpdateOrderTimeCompanyCommandHandler : IRequestHandler<UpdateOrderTimeCompanyCommandRequest, UpdateOrderTimeCompanyCommandResponse>
    {
        readonly ICompanyReadRepository _companyreadRepository;
        readonly ICompanyWriteRepository _companywriteRepository;

        public UpdateOrderTimeCompanyCommandHandler(ICompanyReadRepository companyreadRepository, ICompanyWriteRepository companywriteRepository)
        {
            _companyreadRepository = companyreadRepository;
            _companywriteRepository = companywriteRepository;
        }

        public async Task<UpdateOrderTimeCompanyCommandResponse> Handle(UpdateOrderTimeCompanyCommandRequest request, CancellationToken cancellationToken)
        {
     
            var com = await _companyreadRepository.GetByIdAsync(request.Id);

            if (com == null)
            {
                return new()
                {
                    IsUpdate = false,
                 
                    Message = "Company Not Found",
                };
            }
            var dateFormat = String.Format("0:hh:mm");



          var  orderStart = DateTime.Parse(request.OrderTimeStart);
           var orderEnd= DateTime.Parse(request.OrderTimeEnd);
            int timeCompare = DateTime.Compare(orderStart, orderEnd);

            if (timeCompare<0) {

                com.OrderRelaseStartTime = request.OrderTimeStart;
                com.OrderRelaseEndTime = request.OrderTimeEnd;
                var result = _companywriteRepository.Update(com);

                return new()
                {
                    IsUpdate = result,
                    Model = com,
                    Message = result ? "Update succesfully" : "Update Error",

                };
            }
            else
            {
                    return new()
                    {
                        IsUpdate = false,
                        Message = "Time Format Max Values 23:59 And Time Format Min Value 00:00 ",

                    };
            }
        }
    }
}
