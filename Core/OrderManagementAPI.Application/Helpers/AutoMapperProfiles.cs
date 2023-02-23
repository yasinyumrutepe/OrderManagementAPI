using AutoMapper;
using OrderManagementAPI.Application.Features.Queries.Company.GetAllCompany;
using OrderManagementAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementAPI.Application.Helpers
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Company, GetAllCompanyQueryResponse>()
                .ReverseMap();
           
        }
    }
}
