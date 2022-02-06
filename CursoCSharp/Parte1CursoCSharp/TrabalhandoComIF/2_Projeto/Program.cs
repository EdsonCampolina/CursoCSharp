using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto com if + boolean e operadores lógicos");
            int idadeMaior = 18;
            int idadeMenor = 17;
            Boolean isResponsavelPresente = true;

            if (isResponsavelPresente)
            {
                Console.WriteLine("Está acompanhado!");
            }
            if (idadeMaior >= 18 || isResponsavelPresente == true)
            {
                Console.WriteLine("Entrada permitida!");
            }
            else
            {
                Console.WriteLine("Entrada negada!");
            }
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
