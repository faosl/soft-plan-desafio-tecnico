using Api2.Aplicacao.Interfaces;
using Api2.Dominio.DTOs.Parametros;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api2.Servico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private ICalculoJurosApp _calculoJurosApp;

        public CalculaJurosController(ICalculoJurosApp calculoJurosApp)
        {
            _calculoJurosApp = calculoJurosApp;
        }

        [HttpGet]
        public async Task<IActionResult> Processar([FromQuery]CalculoJurosParametro calculoJurosParametro)
        {
            return Ok(await _calculoJurosApp.Processar(calculoJurosParametro));
        }

    }
}
