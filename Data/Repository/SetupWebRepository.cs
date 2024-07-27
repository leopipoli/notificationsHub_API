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

        public async Task<SetupWebDto> SelectById(int idConfiguracao)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idConfiguracao", idConfiguracao);

            return await SelectById<SetupWebDto>(SetupWebScripts.SelectByIdSetupWeb(), parameters);
        }

        public async Task<int> InsertAsync(SetupWebEntity entity)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@IdConfiguracao", entity.IdConfiguracao);
            parameters.Add("@NomeDoSite", entity.NomeDoSite);
            parameters.Add("@EnderecoDoSite", entity.EnderecoDoSite);
            parameters.Add("@ImagemDoIcone", entity.ImagemDoIcone);
            parameters.Add("@TextoMensagemPermissao", entity.TextoMensagemPermissao);
            parameters.Add("@TextoBotaoPermitir", entity.TextoBotaoPermitir);
            parameters.Add("@TextoBotaoNegar", entity.TextoBotaoNegar);
            parameters.Add("@TituloNotificacaoBoasVindas", entity.TituloNotificacaoBoasVindas);
            parameters.Add("@TextoMensagemBoasVindas", entity.TextoMensagemBoasVindas);
            parameters.Add("@HabilitarLinkDestino", entity.HabilitarLinkDestino);
            parameters.Add("@EnderecoLinkDestino", entity.EnderecoLinkDestino);

            return await InsertAndGetIdAsync(SetupWebScripts.InsertSetupWeb(), parameters);
        }
    }
}

