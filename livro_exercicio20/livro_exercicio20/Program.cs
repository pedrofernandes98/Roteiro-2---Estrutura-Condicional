using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro_exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string categoria;

            Console.WriteLine("Digite a idade do nadador:");
            idade = int.Parse(Console.ReadLine());

            if(idade < 5)
            {
                Console.WriteLine("Não existe categoria para essa idade");
            }
            else
            {
                if (idade > 30)
                {
                    categoria = "Sênior";
                }
                else if (idade >= 16)
                {
                    categoria = "Adulto";
                }
                else if (idade >= 11)
                {
                    categoria = "Adolescente";
                }
                else if (idade >= 8)
                {
                    categoria = "Juvenil";
                }
                else
                {
                    categoria = "Infantil";
                }

                Console.WriteLine("O nadador pertence a categoria " + categoria);
            }

            Console.ReadKey();
            
        }
    }
}
