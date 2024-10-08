﻿using Data.Repository;
using Domain.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            // Obtém a string de conexão do appsettings.json
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Registra o repositório com a string de conexão
            serviceCollection.AddScoped<IConfiguracaoRepository>(provider => new ConfiguracaoRepository(connectionString));
            serviceCollection.AddScoped<ISetupEmailRepository>(provider => new SetupEmailRepository(connectionString));
            serviceCollection.AddScoped<ISetupWebRepository>(provider => new SetupWebRepository(connectionString));
            serviceCollection.AddScoped<ISetupSMSRepository>(provider => new SetupSMSRepository(connectionString));
        }
    }
}
