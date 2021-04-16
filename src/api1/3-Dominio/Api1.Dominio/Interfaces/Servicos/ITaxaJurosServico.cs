using Api1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api1.Dominio.Interfaces.Servicos
{
    public interface ITaxaJurosServico
    {
        Task<TaxaJuros> ObterPadrao();
    }
}
