using Domain.DTOs.SetupEmail;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SetupEmailController : ControllerBase
    {
        private ISetupEmailService _setupEmailService;

        public SetupEmailController(ISetupEmailService setupEmailService) 
        {
            _setupEmailService = setupEmailService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult> ObterSetupEmailPorId(int id)
        {
            try
            {
                return Ok(await _setupEmailService.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost("Post")]
        public async Task<ActionResult> CadastrarSetupEmail(SetupEmailDto setupEmail)
        {
            try
            {
                return Ok(await _setupEmailService.Post(setupEmail));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
