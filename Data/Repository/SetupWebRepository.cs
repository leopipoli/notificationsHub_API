using Dapper;
using Data.Scripts;
using Domain.DTOs.SetupWeb;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class SetupWebRepository : BaseRepository, ISetupWebRepository
    {
        public SetupWebRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<SetupWebDto> SelectById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            return await SelectById<SetupWebDto>(SetupWebScripts.SelectByIdSetupWeb(), parameters);
        }

        public async Task<int> InsertAsync(SetupWebEntity entity)
        {
            var parameters = new DynamicParameters();


            return await InsertAndGetIdAsync(SetupWebScripts.InsertSetupWeb(), entity);
        }
    }
}

