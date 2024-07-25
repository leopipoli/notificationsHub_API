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

        public async Task<IEnumerable<ConfiguracaoDto>> GetAll()
        {
            return await _configuracaoRepository.SelectAll();
        }

        public async Task<ConfiguracaoDto> GetById(int id)
        {
            return await _configuracaoRepository.SelectById(id);
        }

        public async Task<int> Post(ConfiguracaoDto configuracaoDto)
        {
            var model = _mapper.Map<ConfiguracaoEntity>(configuracaoDto);
            return await _configuracaoRepository.InsertAsync(model);
        }
    }
}
