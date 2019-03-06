using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_atual, salario_novo;
            Console.WriteLine("Digite o salário do funcionário:");
            salario_atual = double.Parse(Console.ReadLine());
            if (salario_atual < 500)
            {
                salario_novo = salario_atual * 1.3;
                Console.WriteLine("O novo salário do funcionário é de R$" + salario_novo);
            }
            else
            {
                Console.WriteLine("Esse funcionário não tem direito a reajuste.");
            }

            Console.ReadKey();
        }
    }
}
