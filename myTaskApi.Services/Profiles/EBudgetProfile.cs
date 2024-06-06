using AutoMapper;
using myTaskApi.Models;
using myTaskApi.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.Profiles
{
    public class EBudgetProfile : Profile
    {
        public EBudgetProfile()
        {
            CreateMap<EBudget, EBudgetDTO>();
        }
    }
}
