using Microsoft.EntityFrameworkCore;
using OrderManagementAPI.Domain.Entities;
using OrderManagementAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }

         

    }
}
