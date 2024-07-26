using Dapper;
using Data.Scripts;
using Domain.DTOs.SetupEmail;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class SetupEmailRepository : BaseRepository, ISetupEmailRepository
    {
        public SetupEmailRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<SetupEmailDto> SelectById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            return await SelectById<SetupEmailDto>(SetupEmailScripts.SelectByIdSetupEmail(), parameters);
        }

        public async Task<int> InsertAsync(SetupEmailEntity entity)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@IdSetupEmail", entity.IdSetupEmail);
            parameters.Add("@IdConfiguracao", entity.IdConfiguracao);
            parameters.Add("@NomeServidorSMTP", entity.NomeServidorSMTP);
            parameters.Add("@PortaEnvio", entity.PortaEnvio);
            parameters.Add("@Login", entity.Login);
            parameters.Add("@Senha", entity.Senha);
            parameters.Add("@NomeRemetente", entity.NomeRemetente);
            parameters.Add("@EmailRemetente", entity.EmailRemetente);

            return await InsertAndGetIdAsync(SetupEmailScripts.InsertSetupEmail(), entity);
        }
    }
}


