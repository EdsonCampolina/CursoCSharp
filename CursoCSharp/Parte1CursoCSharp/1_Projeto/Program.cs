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
            Console.WriteLine("Trabalhando com variáveis de texto!");

            char Letra = 'O';
            Console.WriteLine(Letra);
            Console.WriteLine();
            Console.WriteLine((char)69);
            Console.WriteLine((char)(69 - 1));
            Console.WriteLine((char)83);
            Console.WriteLine((char)79);
            Console.WriteLine((char)78);
            string nome = "Edson ";
            Console.WriteLine(nome);
            string multiplasLinhas =
@"Primeira linha 
segunda linha
terceira linha";

            string Frase = "Boa noite ";
            Console.WriteLine(Frase + nome + Letra);
            Console.WriteLine(multiplasLinhas);

            Console.WriteLine("Fim do programa. tecle enter...");
            Console.ReadLine();
        }

    }
}
