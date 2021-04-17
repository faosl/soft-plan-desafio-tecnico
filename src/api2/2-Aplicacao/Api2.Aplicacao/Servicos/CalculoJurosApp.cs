using Api2.Aplicacao.Interfaces;
using Api2.Dominio.DTOs.Parametros;
using Api2.Dominio.Entidades;
using Api2.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api2.Aplicacao.Servicos
{
    public class CalculoJurosApp : ICalculoJurosApp
    {
        private readonly ICalculoJurosServico _calculoJurosServico;

        public CalculoJurosApp(ICalculoJurosServico calculoJurosServico)
        {
            _calculoJurosServico = calculoJurosServico;
        }

        public Task<CalculoJuros> Processar(CalculoJurosParametro calculoJurosParametro) 
            => _calculoJurosServico.Processar(calculoJurosParametro);
    }
}
