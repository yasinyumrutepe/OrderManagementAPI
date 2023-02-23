using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Product.CreateProduct
{
    public class CreateProductCommandRequest:IRequest<CreateProductCommandResponse>
    {

        public int CompanyId { get; set; }
        public string ProductName { get; set; }
        public int StockAmount { get; set; }
        public float Price { get; set; }
    }
}
