using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.UpdateOrderTimeCompany
{
    public class UpdateOrderTimeCompanyCommandResponse
    {
        public Domain.Entities.Company Model { get; set; }

      
        public string Message { get; set; }

        public bool IsUpdate { get; set; }


    }
}
