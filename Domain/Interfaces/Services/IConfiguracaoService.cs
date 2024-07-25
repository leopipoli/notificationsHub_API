using Domain.DTOs.Configuracao;

namespace Domain.Interfaces.Services
{
    public interface IConfiguracaoService
    {
        Task<List<ConfiguracaoDto>> GetAll();
        Task<ConfiguracaoDto> GetById(int idConfiguracao);
        Task<int> Post(ConfiguracaoDto user);
    }
}

