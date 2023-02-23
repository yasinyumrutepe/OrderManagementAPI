using OrderManagementAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Domain.Entities
{
    public class Order:BaseEntity
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public string OrdererName { get; set; }
        public string OrderTime { get; set; }
        public ICollection<Product> Products { get; set; }
        public Company Company { get; set; }
    }
}
