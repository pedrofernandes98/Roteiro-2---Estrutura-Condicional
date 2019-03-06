using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, maior;
            Console.WriteLine("Digite o primeiro número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            n3 = double.Parse(Console.ReadLine());

            if(n1 >= n2)
            {
                if(n1 >= n3)
                {
                    maior = n1;
                }
                else
                {
                    maior = n3;
                }
            }
            else if(n2 >= n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            Console.WriteLine("O maior número é o " + maior);
            Console.ReadKey();
        }
    }
}
