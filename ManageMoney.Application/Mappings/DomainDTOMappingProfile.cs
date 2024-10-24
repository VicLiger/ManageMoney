using AutoMapper;
using ManageMoney.Application.DTOs;
using ManageMoney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMoney.Application.Mappings
{
    public class DomainDTOMappingProfile : Profile
    {
        public DomainDTOMappingProfile()
        {
            CreateMap<AccountCash, AccountCashDTO>().ReverseMap();
            CreateMap<Consumption, ConsumptionDTO>().ReverseMap();
            CreateMap<FinancialObjective, FinancialObjectiveDTO>().ReverseMap();
            CreateMap<Investiment, InvestimentDTO>().ReverseMap();
            CreateMap<Performance, PerfomanceDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();


        }
    }
}
