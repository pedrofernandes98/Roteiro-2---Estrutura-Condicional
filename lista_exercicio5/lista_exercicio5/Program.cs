using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double n1, n2, resultado1, resultado2;

            Console.WriteLine("Menu de Opções:\n1 - O primeiro número elevado ao segundo número\n2- Raiz quadrada de cada um dos números(se possível)");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite o primeiro número:");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = double.Parse(Console.ReadLine());

                    resultado1 = Math.Pow(n1, n2);

                    Console.WriteLine(n1 + " elevado a " + n2 + " = " + resultado1);
                break;

                case 2:
                    Console.WriteLine("Digite o primeiro número:");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = double.Parse(Console.ReadLine());

                    
                    
                    if(n1 >= 0)
                    {
                        resultado1 = Math.Sqrt(n1);
                        Console.WriteLine("A raiz quadrade de " + n1 + " é " + resultado1);
                    }
                    else
                    {
                        Console.WriteLine("O número " + n1 + " é negativo logo não tem raiz real");
                    }

                    if (n2 >= 0)
                    {
                        resultado2 = Math.Sqrt(n2);
                        Console.WriteLine("A raiz quadrade de " + n2 + " é " + resultado2);
                    }
                    else
                    {
                        Console.WriteLine("O número " + n2 + " é negativo logo não tem raiz real");
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
