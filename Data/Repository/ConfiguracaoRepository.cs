using Dapper;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class ConfiguracaoRepository : BaseRepository, IConfiguracaoRepository
    {
        public ConfiguracaoRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<int> InsertAsync(ConfiguracaoEntity entity)
        {
            var sql = @"INSERT INTO Configuracao (NomeAplicativo, SetupWeb, SetupEmail, SetupSMS) 
                        VALUES (@NomeAplicativo, @SetupWeb, @SetupEmail, @SetupSMS);
                        SELECT CAST(SCOPE_IDENTITY() as int);";

            return await InsertAndGetIdAsync(sql, entity);
        }
    }
}


