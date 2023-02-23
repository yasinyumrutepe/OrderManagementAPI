using MediatR;
using OrderManagementAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Commands.Product.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;
        readonly IProductWriteRepository _productWriteRepository;

        public CreateProductCommandHandler(ICompanyReadRepository companyReadRepository, IProductWriteRepository productWriteRepository)
        {
            _companyReadRepository = companyReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var company = await _companyReadRepository.GetByIdAsync(request.CompanyId);
            if (company == null)
            {
                return new()
                {
                    Message = "Company Not Found",
                    IsCreated = false,
                };
            }

            Domain.Entities.Product product = new Domain.Entities.Product();


            product.CompanyId = company.Id;
            product.ProductName = request.ProductName;
            product.Price = request.Price;
            product.StockAmount= request.StockAmount;
            product.CreatedAt = DateTime.Now;
            var newProduct = await _productWriteRepository.AddAsync(product);
            await _productWriteRepository.SaveAsync();

            return new()
            {
                Message = "Product Added Succesfully",
                IsCreated = true,
                Product = newProduct,
            };






        }
    }
}
