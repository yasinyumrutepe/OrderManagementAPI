using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Company.UpdateOrderTimeCompany
{
    public class UpdateOrderTimeCompanyCommandRequest:IRequest<UpdateOrderTimeCompanyCommandResponse>
    {
        public int Id { get; set; }
        public string OrderTimeStart { get; set; }
        public string OrderTimeEnd { get; set; }

    }
}
