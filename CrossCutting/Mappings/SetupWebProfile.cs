using AutoMapper;
using Domain.DTOs.SetupWeb;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class SetupWebProfile : Profile
    {
        public SetupWebProfile()
        {
            CreateMap<SetupWebDto, SetupWebEntity>()
                .ReverseMap();
        }
    }
}
