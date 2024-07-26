using Domain.DTOs.SetupWeb;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Apresentacao.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SetupWebController : ControllerBase
  {
        private ISetupWebService _setupWebService;

        public SetupWebController(ISetupWebService SetupWebService)
        {
            _setupWebService = SetupWebService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterSetupWebPorId(int id)
        {
            try
            {
                return Ok(await _setupWebService.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarSetupWeb(SetupWebDto SetupWeb)
        {
            try
            {
                return Ok(await _setupWebService.Post(SetupWeb));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
