using AutoMapper;
using Domain.DTOs.SetupSMS;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class SetupSMSService : ISetupSMSService
    {
        ISetupSMSRepository _setupSMSRepository;
        public readonly IMapper _mapper;

        public SetupSMSService(
            ISetupSMSRepository setupSMSRepository,
            IMapper mapper)
        {
            _setupSMSRepository = setupSMSRepository;
            _mapper = mapper;
        }

        public async Task<SetupSMSDto> GetById(int id)
        {
            return await _setupSMSRepository.SelectById(id);
        }

        public async Task<int> Post(SetupSMSDto setupSMSDto)
        {
            var model = _mapper.Map<SetupSMSEntity>(setupSMSDto);
            return await _setupSMSRepository.InsertAsync(model);
        }
    }
}
