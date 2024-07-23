using AutoMapper;

namespace CrossCutting.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static void ConfigureProfiles(IMapperConfigurationExpression cfg)
        {
            cfg.AddProfile<UserProfile>();
        }
    }
}