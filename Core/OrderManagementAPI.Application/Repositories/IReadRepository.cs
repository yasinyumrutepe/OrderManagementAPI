using OrderManagementAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Repository
{
    public interface IReadRepository<T>:IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);



    }
}
