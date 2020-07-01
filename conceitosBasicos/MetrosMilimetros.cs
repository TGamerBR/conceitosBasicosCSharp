using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixacaoFundamentos
{
    class MetrosMilimetros
    {   public float Metros { get; set; }
        public float MetrosParaMilimetros()
        {
            return Metros * 1000;
        }
    }
}
