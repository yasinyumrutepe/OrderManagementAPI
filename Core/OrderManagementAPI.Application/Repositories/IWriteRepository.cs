using OrderManagementAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Repository
{
    public interface IWriteRepository<T> :IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T model);

        bool Update(T model);

        Task<int> SaveAsync();
    }
}
