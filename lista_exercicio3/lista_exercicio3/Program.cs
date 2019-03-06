using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n_trab, n_aval, n_exame, media;
            char conceito;

            Console.WriteLine("Digite a nota do aluno no Trabalho de Laboratório:");
            n_trab = double.Parse(Console.ReadLine());
            if(n_trab < 0 || n_trab > 10)
            {
                Console.WriteLine("Nota Inválida");
            }
            else
            {
                Console.WriteLine("Digite a nota do aluno na Avaliação Semestral:");
                n_aval = double.Parse(Console.ReadLine());
                if (n_aval < 0 || n_aval > 10)
                {
                    Console.WriteLine("Nota Inválida");
                }
                else
                {
                    Console.WriteLine("Digite a nota do aluno no Exame Final:");
                    n_exame = double.Parse(Console.ReadLine());
                    if (n_exame < 0 || n_exame > 10)
                    {
                        Console.WriteLine("Nota Inválida");
                    }
                    else
                    {
                        media = ((n_trab * 2) + (n_aval * 3) + (n_exame * 5)) / 10;

                        if(media >= 8)
                        {
                            conceito = 'A';
                        }
                        else if(media >= 7)
                        {
                            conceito = 'B';
                        }
                        else if(media >= 6)
                        {
                            conceito = 'C';
                        }
                        else if(media >= 5)
                        {
                            conceito = 'D';
                        }
                        else
                        {
                            conceito = 'E';
                        }

                        Console.WriteLine("Media do Aluno: " + media + "\nConceito: " + conceito);
                      
                    }
                }
            }
            Console.ReadKey();
        }
        
    }
}
