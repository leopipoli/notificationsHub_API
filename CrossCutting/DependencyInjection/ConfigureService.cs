using Application.Services;
using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IConfiguracaoService, ConfiguracaoService>();
            serviceCollection.AddTransient<ISetupWebService, SetupWebService>();
            serviceCollection.AddTransient<ISetupEmailService, SetupEmailService>();
            serviceCollection.AddTransient<ISetupSMSService, SetupSMSService>();
        }
    }
}
