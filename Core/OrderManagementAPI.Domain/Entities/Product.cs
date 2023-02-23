using OrderManagementAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Domain.Entities
{
    public class Product:BaseEntity
    {
        public int CompanyId { get; set; }
        public string ProductName { get; set; }
        public int StockAmount { get; set; }
        public float Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
