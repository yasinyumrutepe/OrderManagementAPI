using OrderManagementAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Features.Queries.Company.GetAllCompany
{
    public class GetAllCompanyQueryResponse
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public bool ApprovelStatus { get; set; }
        public string OrderRelaseStartTime { get; set; }
        public string OrderRelaseEndTime { get; set; }
    }
}
