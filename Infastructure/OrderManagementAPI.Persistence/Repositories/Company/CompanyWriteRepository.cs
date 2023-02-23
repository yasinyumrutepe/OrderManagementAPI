using Microsoft.EntityFrameworkCore;
using OrderManagementAPI.Application.Features.Commands.Company.CreateCompany;
using OrderManagementAPI.Application.Repositories;
using OrderManagementAPI.Domain.Entities;
using OrderManagementAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Persistence.Repositories
{
    public class CompanyWriteRepository : WriteRepository<Company>, ICompanyWriteRepository
    {
        public CompanyWriteRepository(OrderManagementAPIDbContext context) : base(context)
        {
        }

        Task ICompanyWriteRepository.AddAsync(CreateCompanyCommandRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
