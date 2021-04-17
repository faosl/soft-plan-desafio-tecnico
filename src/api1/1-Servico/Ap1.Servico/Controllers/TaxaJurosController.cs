using Api1.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1.Servico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosApp _taxaJurosApp;

        public TaxaJurosController(ITaxaJurosApp taxaJuros)
        {
            _taxaJurosApp = taxaJuros;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {            
            return Ok(await _taxaJurosApp.ObterPadrao());            
        }
    }
}
