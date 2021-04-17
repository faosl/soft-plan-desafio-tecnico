using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api2.Servico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public ShowMeTheCodeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {            
            return Ok(new { UrlGit = _configuration["UrlGit"] });
        }
    }
}
