using Domain.DTOs;

namespace Domain.Interfaces
{
    public interface IConfiguracaoService
    {
        Task<ConfiguracaoDto> Post(ConfiguracaoDto user);
    }
}

