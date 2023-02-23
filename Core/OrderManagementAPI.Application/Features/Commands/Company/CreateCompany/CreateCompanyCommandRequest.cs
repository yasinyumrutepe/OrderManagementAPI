using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyCommandRequest:IRequest<CreateCompanyCommandResponse>
    {
        
        public string CompanyName { get; set; }
        public bool ApprovelStatus { get; set; }
        public string OrderRelaseStartTime { get; set; }
        public string OrderRelaseEndTime { get; set; }

    }
}
