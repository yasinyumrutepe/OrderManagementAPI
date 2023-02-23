﻿using Microsoft.EntityFrameworkCore;
using OrderManagementAPI.Application.Repository;
using OrderManagementAPI.Domain.Entities.Common;
using OrderManagementAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {

        private readonly OrderManagementAPIDbContext _context;

        public ReadRepository(OrderManagementAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        => Table;

        public async Task<T> GetByIdAsync(int id)
            =>await Table.FindAsync( id);
        
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
       =>await  Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        => Table.Where(method);
    }
}
