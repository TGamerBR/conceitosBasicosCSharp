using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixacaoFundamentos
{
    public class AluguelCarro
    {
        public decimal ValorPagar { get; private set; }
        public AluguelCarro(decimal kmInicial, decimal kmFinal, int qtdDias )
        {
            decimal valorDiaria = 95.00m;
            decimal valorKilometro = 0.35m;
            decimal kmRodados = kmFinal - kmInicial;

            ValorPagar = qtdDias * valorDiaria + kmRodados*valorKilometro;

        }
    }
}
