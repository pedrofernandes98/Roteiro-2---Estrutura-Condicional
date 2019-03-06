using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo_medio, credito;
            Console.WriteLine("Digite o saldo médio do cliente no último ano:");
            saldo_medio = double.Parse(Console.ReadLine());
            if(saldo_medio > 400)
            {
                credito = saldo_medio * 0.3;
            }
            else if(saldo_medio > 300)
            {
                credito = saldo_medio * 0.25;
            }
            else if(saldo_medio > 200)
            {
                credito = saldo_medio * 0.2;
            }
            else
            {
                credito = saldo_medio * 0.1;
            }

            Console.WriteLine("O cliente tem direto a R$" + credito + " de crédito especial.");
            Console.ReadKey();
        }
    }
}
