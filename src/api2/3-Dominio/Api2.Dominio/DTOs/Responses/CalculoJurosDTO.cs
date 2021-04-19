using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api2.Dominio.DTOs.Responses
{
    public class CalculoJurosDTO
    {
        public double ValorInicial { get; set; }

        public double TaxaJuros { get; set; }

        public int TempoEmMeses { get; set; }

        public double ValorFinal { get; set; }
    }
}
