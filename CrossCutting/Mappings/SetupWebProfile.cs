using AutoMapper;

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
