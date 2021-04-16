using Api1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api1.Aplicacao.Interfaces
{
    public interface ITaxaJurosApp
    {
        Task<TaxaJuros> ObterPadrao();
    }
}
