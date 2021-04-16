using Api1.Dominio.Entidades;
using Api1.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api1.Dominio.Servicos
{
    public class TaxaJurosServico : ITaxaJurosServico
    {
        public Task<TaxaJuros> ObterPadrao() => Task.Run(() => new TaxaJuros());

    }
}
