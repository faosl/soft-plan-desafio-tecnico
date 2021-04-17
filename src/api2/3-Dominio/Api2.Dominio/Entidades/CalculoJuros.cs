using Api2.Dominio.DTOs.Facade;
using Api2.Dominio.DTOs.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api2.Dominio.Entidades
{
    public class CalculoJuros
    {
        public double ValorInicial { get; private set; }

        public double TaxaJuros { get; private set; }

        public int TempoEmMeses { get; private set; }

        public double ValorFinal { get; private set; }

        public CalculoJuros(CalculoJurosParametro calculoJurosParametro,
                            TaxaJurosDTO taxaJurosDTO)
        {
            ValorInicial = calculoJurosParametro.ValorInicial;
            TaxaJuros = taxaJurosDTO.Valor;
            TempoEmMeses = calculoJurosParametro.TempoEmMeses;
        }

        public CalculoJuros Processar()
        {
            var resultadoFormula = ValorInicial * Math.Pow(1 + TaxaJuros, TempoEmMeses);

            ValorFinal = Truncar(resultadoFormula);

            return this;
        }

        private double Truncar(double valor, int casasDecimais = 2) {
            var valorTruncagem = Math.Pow(10, casasDecimais);
            return Math.Truncate(valorTruncagem * valor) / valorTruncagem;
        }

    }
}
