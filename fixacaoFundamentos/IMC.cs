using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixacaoFundamentos
{
    class IMC
    {
        public float ValorIMC { get; private set; }
        public string ClassIMC { get; private set; }
        public IMC(float altura, float peso, string sexo)
        {
            ValorIMC = (peso / (altura * altura));

            if (ValorIMC < 18.5)
            { 
                ClassIMC = "Abaixo do Peso";
            }
            else if(ValorIMC > 18.5 && ValorIMC < 25.0)
            {
                ClassIMC = "Peso ideal (parabéns)";
            }
            else if(ValorIMC >= 25.0 && ValorIMC < 30.0)
            {
                ClassIMC = "Levemente acima do Peso";
            }
            else if (ValorIMC >= 30.0 && ValorIMC < 35.0)
            {
                ClassIMC = "Obesidade Grau I";
            }
            else if (ValorIMC >= 35.0 && ValorIMC < 40.0)
            {
                ClassIMC = "Obesidade Grau II (severa)";
            }
            else if (ValorIMC > 40.0)
            {
                ClassIMC = "Obesidade III (morbida)";
            }

        }
    }
}
