﻿using AutoMapper;
using Domain.DTOs;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class ConfiguracaoProfile : Profile
    {
        public ConfiguracaoProfile()
        {    
            CreateMap<ConfiguracaoDto, ConfiguracaoEntity>()
                .ReverseMap();
        }
    }
}
