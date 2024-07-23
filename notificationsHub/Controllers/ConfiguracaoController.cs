using Domain.DTOs;
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

        [HttpPost]
        public async Task<ActionResult> CadastrarConfiguracao(ConfiguracaoDto configuracao)
        {
            try
            {
                return Ok(_configuracaoService.Post(configuracao));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
