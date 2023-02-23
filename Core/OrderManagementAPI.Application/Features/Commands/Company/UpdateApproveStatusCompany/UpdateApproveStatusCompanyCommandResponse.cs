using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.UpdateApproveStatusCompany
{
    public class UpdateApproveStatusCompanyCommandResponse
    {
        public Domain.Entities.Company Model { get; set; }
        public bool ApproveStatus { get; set; }

        public bool IsUpdate { get; set; } 
        public string Message { get; set; }
    }
}
