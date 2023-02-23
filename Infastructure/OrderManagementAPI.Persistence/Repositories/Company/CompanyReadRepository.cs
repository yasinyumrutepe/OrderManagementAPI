using Microsoft.EntityFrameworkCore;
using OrderManagementAPI.Application.Repositories;
using OrderManagementAPI.Domain.Entities;
using OrderManagementAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Persistence.Repositories
{
    public class CompanyReadRepository : ReadRepository<Company> , ICompanyReadRepository
    {
        public CompanyReadRepository(OrderManagementAPIDbContext context) : base(context)
        {
        }
    }
}
