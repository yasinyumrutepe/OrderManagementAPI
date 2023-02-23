using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyCommandResponse
    {
        public Domain.Entities.Company Company { get; set; }
        public bool IsCreated { get; set; }
        public string Message { get; set; }


    }
}
