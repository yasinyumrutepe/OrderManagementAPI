using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandResponse
    {
        public Domain.Entities.Order Order { get; set; }
        public string Message { get; set; }
        public bool IsCreated { get; set; }
    
    }
}
