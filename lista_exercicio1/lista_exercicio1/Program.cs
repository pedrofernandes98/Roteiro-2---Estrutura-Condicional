using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            double peso, novo_peso;

            Console.WriteLine("Digite a opção desejada:\n a- O novo peso caso engorde 15% do peso atual\n b- O novo peso caso emagreça 20% do  peso atual.");
            op = char.Parse(Console.ReadLine().ToLower());

            switch (op)
            {
                case 'a':
                    Console.WriteLine("Digite o peso:");
                    peso = double.Parse(Console.ReadLine());

                    novo_peso = peso * 1.15;

                    Console.WriteLine("Caso o peso aumente 15% o novo peso será de " + novo_peso);
                break;

                case 'b':
                    Console.WriteLine("Digite o peso:");
                    peso = double.Parse(Console.ReadLine());

                    novo_peso = peso * 0.8;

                    Console.WriteLine("Caso o peso reduza 20% o novo peso será de " + novo_peso);
                break;

                default:
                    Console.WriteLine("Opção Inválida!");
                break;
            }

            Console.ReadKey();

        }
    }
}
