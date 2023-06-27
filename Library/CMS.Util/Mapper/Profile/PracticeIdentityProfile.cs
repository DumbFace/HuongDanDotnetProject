using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Roles;
using Domain.Users;
using Microsoft.AspNetCore.Identity;
using PracticeIdentity.DTOS;
using PracticeIdentity.Models;

namespace PracticeIdentity.Profiles
{
    public class PracticeIdentityProfile : Profile
    {
        public PracticeIdentityProfile()
        {
            CreateMap<IdentityUser, RegisterDTO>();
            CreateMap<IdentityRole, RoleDTO>();
            CreateMap<RoleDTO, IdentityRole>();
            CreateMap<IdentityRole, RoleModel>();
            CreateMap<IdentityUser, UserViewModel>();
            CreateMap<UserViewModel, IdentityUser>();
            CreateMap<IdentityUser, RegisterModel>().ForMember(s =>
                s.Email, opts => opts.MapFrom(s => s.UserName)
            );

        }
    }
}