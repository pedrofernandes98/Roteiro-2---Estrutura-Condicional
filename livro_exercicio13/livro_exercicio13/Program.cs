using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco_atual, novo_preco; 
            string classe;

            Console.WriteLine("Digite o preço atual do produto:");
            preco_atual = double.Parse(Console.ReadLine());

            if(preco_atual <= 50)
            {
                novo_preco = preco_atual * 1.05;
            }
            else if(preco_atual <= 100)
            {
                novo_preco = preco_atual * 1.10;
            }
            else
            {
                novo_preco = preco_atual * 1.15;
            }

            if(novo_preco <= 80)
            {
                classe = "Barato";
            }
            else if(novo_preco <= 120)
            {
                classe = "Normal";
            }
            else if(novo_preco <= 200)
            {
                classe = "Caro";
            }
            else
            {
                classe = "Muito Caro";
            }

            Console.WriteLine("O novo preço do produto é R$" + novo_preco + "\nClassificação: " + classe);
            Console.ReadKey();
        }
    }
}
