using Domain.DTOs.SetupSMS;
using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface ISetupSMSRepository
    {
        Task<SetupSMSDto> SelectById(int IdConfiguracao);
        Task<int> InsertAsync(SetupSMSEntity entity);
    }
}
