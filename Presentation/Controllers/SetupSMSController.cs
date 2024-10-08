﻿using Domain.DTOs.SetupSMS;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SetupSMSController : ControllerBase
    {
        private ISetupSMSService _setupSMSService;

        public SetupSMSController(ISetupSMSService SetupSMSService)
        {
            _setupSMSService = SetupSMSService;
        }

        [HttpGet("GetById/{idConfiguracao}")]
        public async Task<ActionResult> ObterSetupSMSPorId(int idConfiguracao)
        {
            try
            {
                return Ok(await _setupSMSService.GetById(idConfiguracao));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost("Post")]
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
