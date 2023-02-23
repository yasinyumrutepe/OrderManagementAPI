using OrderManagementAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Domain.Entities
{
    public class Company:BaseEntity
    {
        public string CompanyName { get; set; }
        public bool ApprovelStatus { get; set; }
        public string OrderRelaseStartTime { get; set; }
        public string OrderRelaseEndTime { get; set; }
    }
}
