using Domain.DTOs.Configuracao;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Apresentacao.Controllers
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

        [HttpGet]
        public async Task<ActionResult> ObterTodasConfiguracoes()
        {
            try
            {
                return Ok(_configuracaoService.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterConfiguracaoPorId(int idConfiguracao)
        {
            try
            {
                return Ok(_configuracaoService.GetById(idConfiguracao));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
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
