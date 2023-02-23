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
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(OrderManagementAPIDbContext context) : base(context)
        {
        }
    }
}
