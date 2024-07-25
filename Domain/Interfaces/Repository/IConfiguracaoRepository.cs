using Domain.DTOs.Configuracao;
using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface IConfiguracaoRepository
    {
        Task<IEnumerable<ConfiguracaoDto>> SelectAll();
        Task<ConfiguracaoDto> SelectById(int id);
        Task<int> InsertAsync(ConfiguracaoEntity entity);
    }
}
