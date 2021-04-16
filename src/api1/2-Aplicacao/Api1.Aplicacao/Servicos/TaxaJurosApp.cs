using Api1.Aplicacao.Interfaces;
using Api1.Dominio.Entidades;
using Api1.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api1.Aplicacao.Servicos
{
    public class TaxaJurosApp : ITaxaJurosApp
    {
        private readonly ITaxaJurosServico _taxaJurosServico;

        public TaxaJurosApp(ITaxaJurosServico taxaJurosServico)
        {
            _taxaJurosServico = taxaJurosServico;
        }

        public Task<TaxaJuros> ObterPadrao() => _taxaJurosServico.ObterPadrao();
    }
}
