﻿using AutoMapper;
using Domain.DTOs.DtoModels;
using Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapper
{
    public class AutoMapper : Profile
	{
        public AutoMapper()
		{
			CreateMap<DtoBranch, Branch>();
			CreateMap<DtoEmployee, Employee>();
			CreateMap<DtoTransfer, DtoTransfer>();
			CreateMap<DtoAccount, Account>().ReverseMap();
			//		   .ForMember(dest =>
			//	dest.AccountID,
			//	opt => opt.MapFrom(src => src.AccountID))
			//.ForMember(dest =>
			//	dest.Type,
			//	opt => opt.MapFrom(src => src.Type))
			//.ForMember(dest =>
			//	dest.Balance,
			//	opt => opt.MapFrom(src => src.Balance))
			//.ForMember(dest =>
			//	dest.CustomerID,
			//	opt => opt.MapFrom(src => src.CustomerID));
			//.ForMember(dest => dest.Customer, opt => opt.Ignore());
		}
	}
}
