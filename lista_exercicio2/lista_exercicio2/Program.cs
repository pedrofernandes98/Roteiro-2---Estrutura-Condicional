using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ordem Descreste: ");
            if (n1 >= n2)
            {
                if(n1 >= n3)
                {
                    if(n2 >= n3)
                    {
                        Console.WriteLine(n1 + " " + n2 + " " + n3);
                    }
                    else
                    {
                        Console.WriteLine(n1 + " " + n3 + " " + n2);
                    }
                }
                else
                {
                    Console.WriteLine(n3 + " " + n1 + " " + n2);
                }
            }
            else
            {
                if(n2 >= n3)
                {
                    if(n1 >= n3)
                    {
                        Console.WriteLine(n2 + " " + n1 + " " + n3);
                    }
                    else
                    {
                        Console.WriteLine(n2 + " " + n3 + " " + n1);
                    }
                }
                else
                {
                    Console.WriteLine(n3 + " " + n2 + " " + n1);
                }
            }

            Console.ReadKey();
        }
    }
}
