using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OrderManagementAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OrderManagementAPIDbContext>
    {
        public OrderManagementAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<OrderManagementAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer("Server=YASINYT;Database=CompanyOrderManagementDb;Trusted_Connection=True;TrustServerCertificate=True");
            return new OrderManagementAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
