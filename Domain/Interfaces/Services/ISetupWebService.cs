using Domain.DTOs.SetupWeb;

namespace Domain.Interfaces.Services
{
    public interface ISetupWebService
    {
        Task<SetupWebDto> GetById(int id);
        Task<int> Post(SetupWebDto user);
    }
}
