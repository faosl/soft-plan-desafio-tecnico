using Api2.Dominio.DTOs.Facade;
using Api2.Dominio.DTOs.Parametros;
using Api2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Api2.Dominio.Teste.Entidades
{
    public class CalculoJurosTeste
    {

        [Theory]
        [ClassData(typeof(CalculoJurosDados))]
        public void Quando_processar(double valorInicial, 
            double taxaJuros, 
            int tempoEmMeses,
            double valorEsperado)
        {
            var parametro = new CalculoJurosParametro()
            {
                TempoEmMeses = tempoEmMeses,
                ValorInicial = valorInicial
            };

            var taxaJurosDTO = new TaxaJurosDTO()
            {
                Valor = taxaJuros
            };

            var calculoJuros = new CalculoJuros(parametro, taxaJurosDTO).Processar();

            Assert.Equal(valorEsperado, calculoJuros.ValorFinal);

        }

    }
}
