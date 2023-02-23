using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Product.CreateProduct
{
    public class CreateProductCommandResponse
    {
        public Domain.Entities.Product Product { get; set; }
        public string Message { get; set; }
        public bool IsCreated { get; set; }
    }
}
