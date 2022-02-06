using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com condicionais!");
            int idadeEdson = 20;
            Boolean isResponsavelPresente = true;

            if (idadeEdson > 18)
            {
                Console.WriteLine("Maior de idade.");
                Console.WriteLine("Entrada permitida!");
            }
            else
            {
                if (isResponsavelPresente == true)
                {
                    Console.WriteLine("responsável presente.");
                    Console.WriteLine("Entrada permitida!");
                }
                else
                {
                    Console.WriteLine("Entrada negada!");
                }
            }
            Console.WriteLine("Fim do programa, tecle qualquer coisa...");
            Console.ReadLine();
        }
    }
}
