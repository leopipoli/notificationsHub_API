using AutoMapper;
using Domain.DTOs.SetupEmail;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class SetupEmailService : ISetupEmailService
    {
        ISetupEmailRepository _setupEmailRepository;
        public readonly IMapper _mapper;

        public SetupEmailService(
            ISetupEmailRepository setupEmailRepository,
            IMapper mapper)
        {
            _setupEmailRepository = setupEmailRepository;
            _mapper = mapper;
        }

        public async Task<SetupEmailDto> GetById(int id)
        {
            return await _setupEmailRepository.SelectById(id);
        }

        public async Task<int> Post(SetupEmailDto setupEmailDto)
        {
            var model = _mapper.Map<SetupEmailEntity>(setupEmailDto);
            return await _setupEmailRepository.InsertAsync(model);
        }
    }
}
