using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OrderManagementAPI.Application.Repository;
using OrderManagementAPI.Domain.Entities.Common;
using OrderManagementAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {   
        readonly private OrderManagementAPIDbContext _context;

        public WriteRepository(OrderManagementAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<T> AddAsync(T model)
        {
          EntityEntry<T> entityEntry=  await Table.AddAsync(model);
        return entityEntry.Entity;
        }
        public bool Update(T model)
        {
            EntityEntry entityEntry= Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
         => await _context.SaveChangesAsync();



    }
}
