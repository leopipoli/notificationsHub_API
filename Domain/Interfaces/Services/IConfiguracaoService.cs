using Domain.DTOs;

namespace Domain.Interfaces.Services
{
    public interface IConfiguracaoService
    {
        Task<ConfiguracaoDto> Post(ConfiguracaoDto user);
    }
}

