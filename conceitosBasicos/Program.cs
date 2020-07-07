using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixacaoFundamentos
{
    class Program
    {
        static SomaDoisNumeros soma = new SomaDoisNumeros();
        static MetrosMilimetros metrosMilimetros = new MetrosMilimetros();
        static CalculaAumento calculaAumento;
        static AluguelCarro aluguelCarro;
        static IMC imc;
        static Tabuada tabuada;

        static void Main(string[] args)
        {
            int loop;
            do
            {
                loop = 0;
                Console.WriteLine("\n" +
                "1 - Para somar dois números;\n" +
                "2 - Converter metros em milimetros;\n" +
                "3 - Calcular aumento de salário;\n" +
                "4 - Calcular valor ao aluguel do veículo;\n" +
                "5 - Verificar IMC;\n" +
                "6 - Criar tabuada;\n" +
                "7 - Exibir até !10;\n" +
                "8 - Exibir apenas ímpares até 100;\n" +
                "9 - Sair;\n\n");

                int escolha = int.Parse(Console.ReadLine());

                Console.Clear();
                loop = escolha;

                switch (escolha)
                {
                    case 1:

                        int numero1 = 20;
                        int numero2 = 22;
                        int result = soma.Somar(numero1, numero2);
                        Console.WriteLine($"O resultado da soma de {numero1} com {numero2} é igual a " + result);
                        break;

                    case 2:
                        Console.WriteLine("Informe a distância em metros: ");
                        metrosMilimetros.Metros = float.Parse(Console.ReadLine());
                        float milimetros = metrosMilimetros.MetrosParaMilimetros();
                        Console.WriteLine($"O resultado da conversão de {metrosMilimetros.Metros} Metros para Milimetros é de {milimetros} milimetros");
                        break;

                    case 3:
                        Console.WriteLine("Informe o saláro atual: ");
                        decimal salario = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Informe o percentual de aumento: ");
                        float percAumento = float.Parse(Console.ReadLine());
                        calculaAumento = new CalculaAumento(salario, percAumento);
                        decimal valorAumento = calculaAumento.NovoSalario - salario;
                        Console.WriteLine("Para o salário de {0}, foi fornecido um aumento de {1}%, assim o novo salário é {2} e o valor do aumento foi de {3}", salario, percAumento, calculaAumento.NovoSalario, valorAumento);
                        break;

                    case 4:
                        Console.WriteLine("Informe a quantidade de dias em que o carro ficou alugado: ");
                        int dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quilometragem inicial: ");
                        decimal quilometragemInicial = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quilometragem final: ");
                        decimal quilometragemFinal = decimal.Parse(Console.ReadLine());
                        aluguelCarro = new AluguelCarro(quilometragemInicial, quilometragemFinal, dias);
                        Console.WriteLine($"O valor a pagar pelo aluguel do veículo é de: {aluguelCarro.ValorPagar}");
                        break;

                    case 5:
                        Console.WriteLine("Informe a sua altura em metros: ");
                        float valAltura = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o seu peso: ");
                        float valPeso = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe seu sexo: ");
                        string valSexo = Console.ReadLine();
                        imc = new IMC(valAltura, valPeso, valSexo);
                        Console.WriteLine($"O resultado do seu IMC é:{imc.ValorIMC}, ou seja, {imc.ClassIMC}");

                        break;

                    case 6:
                        Console.WriteLine("Você deseja fazer tabuada de qual número? ");
                        int valor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Deseja fazer até que valor? ");
                        int valor2 = int.Parse(Console.ReadLine());

                        tabuada = new Tabuada(valor, valor2);
                        break;

                    case 7:
                        int i;

                        int fatorial = 1;
                        for (i = 1; i <= 10; i++)
                        {
                            fatorial *= i;
                            Console.WriteLine(i + " fatorial = " + fatorial);
                        }
                        break;

                    case 8:
                        int cont;

                        for (cont = 0; cont <= 100; cont++)
                        {
                            if (cont % 2 != 0)
                            {
                                Console.WriteLine(cont);
                            }
                        }
                        break;

                    case 9:
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                escolha = 0;
                Console.ReadKey();
                Console.Clear();
            } while (loop != 9);
        }
    }
}
