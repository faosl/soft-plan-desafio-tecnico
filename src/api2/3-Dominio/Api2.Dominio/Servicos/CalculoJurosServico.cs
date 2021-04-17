using Api2.Dominio.DTOs;
using Api2.Dominio.DTOs.Parametros;
using Api2.Dominio.Entidades;
using Api2.Dominio.Interfaces.Facades;
using Api2.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api2.Dominio.Servicos
{
    public class CalculoJurosServico : ICalculoJurosServico
    {
        private readonly ITaxaJurosFacade _taxaJurosFacade;

        public CalculoJurosServico(ITaxaJurosFacade taxaJurosFacade)
        {
            _taxaJurosFacade = taxaJurosFacade;
        }

        public async Task<CalculoJuros> Processar(CalculoJurosParametro calculoJurosParametro)
        {
            var taxaJurosDTO = await _taxaJurosFacade.GetAsync();

            var calculoJuros = new CalculoJuros(calculoJurosParametro, taxaJurosDTO);

            return calculoJuros.Processar();
        }
    }
}
