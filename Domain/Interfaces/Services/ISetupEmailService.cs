using Domain.DTOs.SetupEmail;

namespace Domain.Interfaces.Services
{
    public interface ISetupEmailService
    {
        Task<SetupEmailDto> GetById(int id);
        Task<int> Post(SetupEmailDto user);
    }
}
