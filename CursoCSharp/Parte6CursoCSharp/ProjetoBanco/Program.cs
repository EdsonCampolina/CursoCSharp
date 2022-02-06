using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa...");

            string url = "pagina?argumentos";
            string novaString;
            int indiceQuestionMark = url.IndexOf('?');
            novaString = url.Substring(indiceQuestionMark+1);
            Console.WriteLine(novaString);

            Console.WriteLine();
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();


        }
    }
}
