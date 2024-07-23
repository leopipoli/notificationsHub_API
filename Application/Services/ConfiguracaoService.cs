using AutoMapper;
using Domain.DTOs;
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

        public Task<ConfiguracaoDto> Post(ConfiguracaoDto configuracao)
        {
            var model = _mapper.Map<ConfiguracaoEntity>(configuracao);
            var entity = _mapper.Map<ConfiguracaoEntity>(model);
            var result = await _configuracaoRepository.InsertAsync(entity);
            return _mapper.Map<ConfiguracaoDto>(result);
        }
    }
}
