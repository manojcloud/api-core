﻿using AspNetCoreApi.Models.Common.Identity;
using AspNetCoreApi.Models.Dto;
using AutoMapper;

namespace AspNetCoreApi.Api.Mapping
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<ApplicationUser, UserDto>();
        }
    }
}