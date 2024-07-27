using Dapper;
using Data.Scripts;
using Domain.DTOs.SetupSMS;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class SetupSMSRepository : BaseRepository, ISetupSMSRepository
    {
        public SetupSMSRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<SetupSMSDto> SelectById(int IdConfiguracao)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@IdConfiguracao", IdConfiguracao);

            return await SelectById<SetupSMSDto>(SetupSMSScripts.SelectByIdConfiguracao(), parameters);
        }

        public async Task<int> InsertAsync(SetupSMSEntity entity)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@IdConfiguracao", entity.IdConfiguracao);
            parameters.Add("@ProvedorSMS", entity.ProvedorSMS);
            parameters.Add("@Login", entity.Login);
            parameters.Add("@Senha", entity.Senha);

            return await InsertAndGetIdAsync(SetupSMSScripts.InsertSetupSMS(), entity);
        }
    }
}

