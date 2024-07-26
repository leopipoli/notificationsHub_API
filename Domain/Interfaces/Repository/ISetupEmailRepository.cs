using Domain.DTOs.SetupEmail;
using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface ISetupEmailRepository
    {
        Task<SetupEmailDto> SelectById(int id);
        Task<int> InsertAsync(SetupEmailEntity entity);
    }
}
