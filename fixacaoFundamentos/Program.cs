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
            Console.WriteLine(
            "A - Para somar dois números;\n" +
            "B - Converter metros em milimetros;\n" +
            "C - Calcular aumento de salário;\n" +
            "D - Calcular valor ao aluguel do veículo;\n" +
            "E - Verificar IMC;\n" +
            "F - Criar tabuada;\n" +
            "G - Exibir até !10;\n" +
            "H - Exibir apenas ímpares até 100;\n" +
            "X - Sair;\n\n");

            Console.WriteLine("Informe qual opção você deseja utilizar(utilize CAPS LOCK): ");
            char escolha = char.Parse(Console.ReadLine());
            Console.Clear();

            switch (escolha)
            {
                case 'A':

                    int numero1 = 20;
                    int numero2 = 22;
                    int result = soma.Somar(numero1, numero2);
                    Console.WriteLine($"O resultado da soma de {numero1} com {numero2} é igual a " + result);
                    Console.Read();
                    break;

                case 'B':
                    Console.WriteLine("Informe a distância em metros: ");
                    metrosMilimetros.Metros = float.Parse(Console.ReadLine());
                    float milimetros = metrosMilimetros.MetrosParaMilimetros();
                    Console.WriteLine($"O resultado da conversão de {metrosMilimetros.Metros} Metros para Milimetros é de {milimetros} milimetros");
                    Console.Read();
                    break;

                case 'C':
                    Console.WriteLine("Informe o saláro atual: ");
                    decimal salario = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Informe o percentual de aumento: ");
                    float percAumento = float.Parse(Console.ReadLine());
                    calculaAumento = new CalculaAumento(salario, percAumento);
                    decimal valorAumento = calculaAumento.NovoSalario - salario;
                    Console.WriteLine("Para o salário de {0}, foi fornecido um aumento de {1}%, assim o novo salário é {2} e o valor do aumento foi de {3}", salario, percAumento, calculaAumento.NovoSalario, valorAumento);
                    Console.Read();
                    break;

                case 'D':
                    Console.WriteLine("Informe a quantidade de dias em que o carro ficou alugado: ");
                    int dias = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quilometragem inicial: ");
                    decimal quilometragemInicial = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quilometragem final: ");
                    decimal quilometragemFinal = decimal.Parse(Console.ReadLine());
                    aluguelCarro = new AluguelCarro(quilometragemInicial, quilometragemFinal, dias);
                    Console.WriteLine($"O valor a pagar pelo aluguel do veículo é de: {aluguelCarro.ValorPagar}");
                    Console.Read();
                    break;

                case 'E':
                    Console.WriteLine("Informe a sua altura em metros: ");
                    float valAltura = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o seu peso: ");
                    float valPeso = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe seu sexo: ");
                    string valSexo = Console.ReadLine();
                    imc = new IMC(valAltura, valPeso, valSexo);
                    Console.WriteLine($"O resultado do seu IMC é:{imc.ValorIMC}, ou seja, {imc.ClassIMC}");
                    Console.Read();

                    break;

                case 'F':


                    Console.WriteLine("Você deseja fazer tabuada de qual número? ");
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Deseja fazer até que valor? ");
                    int valor2 = int.Parse(Console.ReadLine());

                    tabuada = new Tabuada(valor, valor2);
                    Console.Read();
                    break;

                case 'G':
                    int i;

                    int fatorial = 1;
                    for (i = 1; i <= 10; i++)
                    {
                        fatorial *= i;
                        Console.WriteLine(i + " fatorial = " + fatorial);
                    }
                    Console.Read();
                    break;

                case 'H':
                    int cont;

                    for (cont = 0; cont <= 100; cont++)
                    {
                        if (cont % 2 != 0)
                        {
                            Console.WriteLine(cont);
                        }
                    }
                    Console.Read();
                    break;

                case 'X':
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    Console.Read();
                    break;
            }
        }
    }
}
