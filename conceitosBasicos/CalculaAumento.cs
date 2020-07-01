using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixacaoFundamentos
{
    class CalculaAumento
    {   
        public decimal NovoSalario { get; private set; }
        public CalculaAumento(decimal sal, float percentual)
        {
            NovoSalario = sal + (sal * (decimal)percentual / 100);
        }
    }
}
