using Domain.DTOs.SetupSMS;

namespace Domain.Interfaces.Services
{
    public interface ISetupSMSService
    {
        Task<SetupSMSDto> GetById(int idConfiguraca);
        Task<int> Post(SetupSMSDto user);
    }
}
