using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api2.Dominio.Teste.Entidades
{
    public class CalculoJurosDados : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1000, 0.01, 1, 1010 };
            yield return new object[] { 1000, 0.01, 2, 1020.1 };
            yield return new object[] { 1000, 0.01, 3, 1030.3 };
            yield return new object[] { 1000, 0.01, 4, 1040.6 };
            yield return new object[] { 1000, 0.01, 5, 1051.01 };
            yield return new object[] { 1000, 0.01, 6, 1061.52 };                                    
            yield return new object[] { 1000, 0.01, 10, 1104.62 };                        
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
