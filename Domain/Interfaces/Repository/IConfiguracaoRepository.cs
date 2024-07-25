using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface IConfiguracaoRepository
    {
        Task<int> InsertAsync(ConfiguracaoEntity entity);
    }
}
