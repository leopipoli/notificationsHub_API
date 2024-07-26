using AutoMapper;
using Domain.DTOs.SetupSMS;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class SetupSMSProfile : Profile
    {
        public SetupSMSProfile()
        {
            CreateMap<SetupSMSDto, SetupSMSEntity>()
                .ReverseMap();
        }
    }
}
