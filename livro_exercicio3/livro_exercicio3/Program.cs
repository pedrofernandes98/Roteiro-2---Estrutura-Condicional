using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Digite um número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            n2 = double.Parse(Console.ReadLine());

            if(n1 < n2)
            {
                Console.WriteLine("O número menor é o " + n1);
            }
            else
            {
                Console.WriteLine("O número menor é o " + n2); //Neste exemplo, se os números forem iguais, ele será impresso nessa condição do else, logo não é necessário incluir essa condição.
            }
            Console.ReadKey();
        }
    }
}
