using Api2.Dominio.DTOs.Responses;
using Api2.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api2.Servico.Teste.Controllers
{
    public class CalculaJurosControllerTeste: IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public CalculaJurosControllerTeste(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData(1000,1,1010)]
        public async Task Quando_calculaJuros(double valorInicial,int tempoEmMeses, double resultado)
        {
            var client = _factory.CreateClient();

            var calculoJuros = await client.GetFromJsonAsync<CalculoJurosDTO>($"CalculaJuros?valorInicial={valorInicial}&tempoEmMeses={tempoEmMeses}");

            Assert.NotNull(calculoJuros);

            Assert.Equal(valorInicial, calculoJuros?.ValorInicial);
            Assert.Equal(tempoEmMeses, calculoJuros?.TempoEmMeses);
            Assert.Equal(resultado, calculoJuros?.ValorFinal);

        }

    }
}
