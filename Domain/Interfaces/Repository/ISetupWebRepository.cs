using Domain.DTOs.SetupWeb;
using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface ISetupWebRepository
    {
        Task<SetupWebDto> SelectById(int id);
        Task<int> InsertAsync(SetupWebEntity entity);
    }
}
