using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using myTaskApi.Models;
using myTaskApi.Services.ViewModels;

namespace myTaskApi.Services.Profiles
{
   public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(des => des.Address,
                opt => opt.MapFrom(src => $"{src.AddressNo},{src.Street},{src.City}"));
        }
    }
}
