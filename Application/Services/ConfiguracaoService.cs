using AutoMapper;
using Domain.DTOs.Configuracao;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class ConfiguracaoService : IConfiguracaoService
    {
        private IConfiguracaoRepository _configuracaoRepository;
        public readonly IMapper _mapper;

        public ConfiguracaoService(
            IConfiguracaoRepository configuracaoRepository, 
            IMapper mapper)
        {
            _configuracaoRepository = configuracaoRepository;
            _mapper = mapper;
        }

        public async Task<List<ConfiguracaoDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ConfiguracaoDto> GetById(int idConfiguracao)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(ConfiguracaoDto configuracaoDto)
        {
            var model = _mapper.Map<ConfiguracaoEntity>(configuracaoDto);
            return await _configuracaoRepository.InsertAsync(model);
        }
    }
}
