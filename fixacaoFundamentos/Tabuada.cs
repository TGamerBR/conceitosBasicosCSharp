using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixacaoFundamentos
{
    class Tabuada
    {
        public Tabuada(int fator, int fator2)
        {
            Console.Clear();
            int contador = 1;
            int resultado = 0;
            while(contador <= fator2)
            {
                resultado = fator * contador;
                Console.WriteLine($"{fator} X {contador} = {resultado}");
                contador++;
                
            }

        }
    }
}
