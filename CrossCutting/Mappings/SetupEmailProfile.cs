using AutoMapper;
using Domain.DTOs;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class SetupEmailProfile : Profile
    {
        public SetupEmailProfile()
        {
            CreateMap<SetupEmailDto, SetupEmailEntity>()
                .ReverseMap();
        }
    }
}
