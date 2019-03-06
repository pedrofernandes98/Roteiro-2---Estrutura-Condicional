using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Digite o valor do coeficiente a:");
            a = double.Parse(Console.ReadLine());
            if(a == 0)
            {
                Console.WriteLine("A equação não é do Segundo Grau!");
            }
            else
            {
                Console.WriteLine("Digite o valor do coeficiente b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Coeficiente c:");
                c = double.Parse(Console.ReadLine());

                delta = (Math.Pow(b, 2) - (4 * a * c));
                
                if(delta < 0)
                {
                    Console.WriteLine("O Delta é menor que zero logo não existe raízes reais para essa equação");
                }
                else if(delta == 0)
                {
                    x1 = (-b / (2 * a));
                    Console.WriteLine( "X1: " + x1 + "\nX2: " + x1);
                }
                else
                {
                    x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = ((-b - Math.Sqrt(delta)) / (2 * a));

                    Console.WriteLine("X1: " + x1 + "\nX2: " + x2);
                }

                
            }
            Console.ReadKey();
        }
    }
}
