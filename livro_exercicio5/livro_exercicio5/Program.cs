using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double n1, n2, resultado;

            Console.WriteLine("Menu de Opções:\n1- Média entre os números digitados\n2- Diferença do maior pelo menor\n3- Produto entre os números digitados\n4- Divisão do primeiro pelo segundo");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite o primeiro número: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    n2 = double.Parse(Console.ReadLine());
                    resultado = (n1 + n2) / 2.0;
                    Console.WriteLine("A média entre os números digitados é " + resultado);
                break;

                case 2:
                    Console.WriteLine("Digite o primeiro número: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    n2 = double.Parse(Console.ReadLine());

                    resultado = n1 - n2;

                    if(resultado < 0)
                    {
                        resultado = resultado * -1;
                    }


                    Console.WriteLine("A diferença do maior pelo menor é " + resultado);
                break;

                case 3:
                    Console.WriteLine("Digite o primeiro número: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    n2 = double.Parse(Console.ReadLine());

                    resultado = n1 * n2;

                    Console.WriteLine("O produto entre os números digitados é " + resultado);

                break;

                case 4:
                    Console.WriteLine("Digite o primeiro número: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    n2 = double.Parse(Console.ReadLine());

                    if(n2 != 0)
                    {
                        resultado = n1 / n2;
                        Console.WriteLine("A divisão do primeiro pelo segundo número é " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Não existe divisão por zero");
                    }

                 break;

                default:
                    Console.WriteLine("Opção Inválida!");
                break;
            }

            Console.ReadKey();
          
        }
    }
}
