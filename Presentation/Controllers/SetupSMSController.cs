using Domain.DTOs.SetupSMS;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetupSMSController : ControllerBase
    {
        private ISetupSMSService _setupSMSService;

        public SetupSMSController(ISetupSMSService SetupSMSService)
        {
            _setupSMSService = SetupSMSService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterSetupSMSPorId(int id)
        {
            try
            {
                return Ok(await _setupSMSService.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarSetupSMS(SetupSMSDto SetupSMS)
        {
            try
            {
                return Ok(await _setupSMSService.Post(SetupSMS));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
