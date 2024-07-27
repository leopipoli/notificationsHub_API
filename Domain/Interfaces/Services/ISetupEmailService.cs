using Domain.DTOs.SetupEmail;

namespace Domain.Interfaces.Services
{
    public interface ISetupEmailService
    {
        Task<SetupEmailDto> GetById(int idConfiguraca);
        Task<int> Post(SetupEmailDto user);
    }
}
