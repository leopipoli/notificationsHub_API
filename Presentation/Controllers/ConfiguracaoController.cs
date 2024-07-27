using Domain.DTOs.Configuracao;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfiguracaoController : ControllerBase
    {
        private IConfiguracaoService _configuracaoService;

        public ConfiguracaoController(IConfiguracaoService configuracaoService)
        {
            _configuracaoService = configuracaoService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> ObterTodasConfiguracoes()
        {
            try
            {
                return Ok(await _configuracaoService.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult> ObterConfiguracaoPorId(int id)
        {
            try
            {
                return Ok(await _configuracaoService.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost("Post")]
        public async Task<ActionResult> CadastrarConfiguracao(ConfiguracaoDto configuracao)
        {
            try
            {
                return Ok(await _configuracaoService.Post(configuracao));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
