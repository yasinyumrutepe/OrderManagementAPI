using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandRequest:IRequest<CreateOrderCommandResponse>
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public string OrdererName { get; set; }

        public string OrderTime { get; set; }
    }
}
