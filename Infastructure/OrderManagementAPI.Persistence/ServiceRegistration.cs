using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagementAPI.Application.Repositories;
using OrderManagementAPI.Persistence.Context;
using OrderManagementAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<OrderManagementAPIDbContext>(options=> options.UseSqlServer("Server=YASINYT;Database=CompanyOrderManagementDb;Trusted_Connection=True;TrustServerCertificate=True"));

            services.AddScoped<ICompanyReadRepository, CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();


            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();


        }
    }
   
}
