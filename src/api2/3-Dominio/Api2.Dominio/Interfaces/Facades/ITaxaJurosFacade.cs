using Api2.Dominio.DTOs;
using Api2.Dominio.DTOs.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api2.Dominio.Interfaces.Facades
{
    public interface ITaxaJurosFacade
    {
        Task<TaxaJurosDTO> GetAsync();
    }
}
