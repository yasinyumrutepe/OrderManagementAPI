using OrderManagementAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Domain.Entities
{
    public class Company:BaseEntity
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public bool ApprovelStatus { get; set; }
        [Required]
        public string OrderRelaseStartTime { get; set; }
        [Required]
        public string OrderRelaseEndTime { get; set; }
    }
}
