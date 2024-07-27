using AutoMapper;
using Domain.DTOs.SetupWeb;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class SetupWebService : ISetupWebService
    {
        ISetupWebRepository _setupWebRepository;
        public readonly IMapper _mapper;

        public SetupWebService(
            ISetupWebRepository SetupWebRepository,
            IMapper mapper)
        {
            _setupWebRepository = SetupWebRepository;
            _mapper = mapper;
        }

        public async Task<SetupWebDto> GetById(int idConfiguracao)
        {
            return await _setupWebRepository.SelectById(idConfiguracao);
        }

        public async Task<int> Post(SetupWebDto setupWebDto)
        {
            var model = _mapper.Map<SetupWebEntity>(setupWebDto);
            return await _setupWebRepository.InsertAsync(model);
        }
    }
}
