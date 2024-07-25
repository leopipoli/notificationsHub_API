using Dapper;
using Data.Scripts;
using Domain.DTOs.Configuracao;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Data.Repository
{
    public class ConfiguracaoRepository : BaseRepository, IConfiguracaoRepository
    {
        public ConfiguracaoRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task<IEnumerable<ConfiguracaoDto>> SelectAll()
        {
            return await SelectAll<ConfiguracaoDto>(ConfiguracaoScripts.SelectAll());
        }

        public async Task<ConfiguracaoDto> SelectById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            return await SelectById<ConfiguracaoDto>(ConfiguracaoScripts.SelectByIdConfiguracao(), parameters);
        }

        public async Task<int> InsertAsync(ConfiguracaoEntity entity)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@NomeAplicativo", entity.NomeAplicativo);
            parameters.Add("@SetupWeb", entity.SetupWeb);
            parameters.Add("@SetupEmail", entity.SetupEmail);
            parameters.Add("@SetupSMS", entity.SetupSMS);

            return await InsertAndGetIdAsync(ConfiguracaoScripts.InsertConfiguracao(), entity);
        }
    }
}


