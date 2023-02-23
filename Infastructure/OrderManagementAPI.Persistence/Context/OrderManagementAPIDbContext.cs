using Microsoft.EntityFrameworkCore;
using OrderManagementAPI.Domain.Entities;
using OrderManagementAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Persistence.Context
{
    public class OrderManagementAPIDbContext:DbContext
    {
        public OrderManagementAPIDbContext(DbContextOptions options):base(options)
       {
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


       







    }


}
