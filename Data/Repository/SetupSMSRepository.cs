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

        public async Task<SetupSMSDto> SelectById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            return await SelectById<SetupSMSDto>(SetupSMSScripts.SelectByIdSetupSMS(), parameters);
        }

        public async Task<int> InsertAsync(SetupSMSEntity entity)
        {
            var parameters = new DynamicParameters();


            return await InsertAndGetIdAsync(SetupSMSScripts.InsertSetupSMS(), entity);
        }
    }
}

