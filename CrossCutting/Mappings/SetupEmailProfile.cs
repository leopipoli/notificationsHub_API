using AutoMapper;
using Domain.DTOs.SetupEmail;
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
