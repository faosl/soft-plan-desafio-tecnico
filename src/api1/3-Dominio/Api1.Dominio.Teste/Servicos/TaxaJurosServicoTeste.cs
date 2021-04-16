using Api1.Dominio.Interfaces.Servicos;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Api1.Dominio.Servicos.Teste
{
    public class TaxaJurosServicoTeste
    {
        private readonly ITaxaJurosServico _taxaJurosServico;

        public TaxaJurosServicoTeste()
        {
            _taxaJurosServico = new TaxaJurosServico();
        }


        [Fact]
        public async Task Quando_obter_taxa_padrao()
        {
            var taxaJuros = await _taxaJurosServico.ObterPadrao();

            Assert.Equal(0.01m, taxaJuros.Valor);
        }
    }
}
