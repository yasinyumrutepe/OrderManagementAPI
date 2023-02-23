using MediatR;
using OrderManagementAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Order.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {   readonly ICompanyReadRepository _companyReadRepository;
        readonly IOrderWriteRepository _orderWriteRepository;

        public CreateOrderCommandHandler(ICompanyReadRepository companyReadRepository, IOrderWriteRepository orderWriteRepository)
        {
            _companyReadRepository = companyReadRepository;
            _orderWriteRepository = orderWriteRepository;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {

            var company = await _companyReadRepository.GetByIdAsync(request.CompanyId);
            if (company == null)
            {
                return new()
                {
                    IsCreated = false,
                    Message = "Company Not Found",
                };
            }
            if (!company.ApprovelStatus)
            {
                return new()
                {
                    Message = "Company Is Not Approved",
                    IsCreated = false
                };
            }
            var orderStart = DateTime.Parse(company.OrderRelaseStartTime);
            var orderEnd = DateTime.Parse(company.OrderRelaseEndTime);
            var orderTime = DateTime.Parse(request.OrderTime);
            int startTimeCompare = DateTime.Compare(orderStart, orderTime);
            int endTimeCompare = DateTime.Compare(orderTime, orderEnd);

            if (startTimeCompare < 0 && endTimeCompare < 0)
            {
                Domain.Entities.Order order = new Domain.Entities.Order();
                order.OrdererName = request.OrdererName;
                order.CompanyId = request.CompanyId;
                order.ProductId = request.ProductId;
                order.OrderTime = request.OrderTime;

                var neworder = await _orderWriteRepository.AddAsync(order);
                await _orderWriteRepository.SaveAsync();

                return new()
                {
                    IsCreated = true,
                    Message = "Order Created Succesfully",
                    Order = neworder,
                };

            }




            return new()
            {
                IsCreated = false,
                Message = "The Company Cannot Take Orders Now Please Try Again During Order Allowance Hours.",
            };


        }   
    }
}
