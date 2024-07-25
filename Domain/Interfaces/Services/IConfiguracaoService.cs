using Domain.DTOs.Configuracao;

namespace Domain.Interfaces.Services
{
    public interface IConfiguracaoService
    {
        Task<IEnumerable<ConfiguracaoDto>> GetAll();
        Task<ConfiguracaoDto> GetById(int id);
        Task<int> Post(ConfiguracaoDto user);
    }
}

