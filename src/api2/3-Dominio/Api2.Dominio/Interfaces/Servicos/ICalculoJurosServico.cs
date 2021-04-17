using Api2.Dominio.DTOs;
using Api2.Dominio.DTOs.Parametros;
using Api2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api2.Dominio.Interfaces.Servicos
{
    public interface ICalculoJurosServico
    {
        Task<CalculoJuros> Processar(CalculoJurosParametro calculoJurosParametro);
    }
}
