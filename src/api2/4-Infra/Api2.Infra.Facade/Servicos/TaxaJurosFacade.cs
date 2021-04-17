using Api2.Dominio.DTOs.Facade;
using Api2.Dominio.Interfaces.Facades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Api2.Infra.Facade.Servicos
{
    public class TaxaJurosFacade : ITaxaJurosFacade
    {
        private readonly HttpClient _httpClient;        

        public TaxaJurosFacade(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<TaxaJurosDTO> GetAsync()
        {
            return _httpClient.GetFromJsonAsync<TaxaJurosDTO>("TaxaJuros");            
        }
    }
}
