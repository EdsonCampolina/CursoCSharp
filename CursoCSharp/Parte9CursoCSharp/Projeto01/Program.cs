using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto01
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com IO. Inicio do programa");
            Console.WriteLine();

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }





            Console.WriteLine();
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }


    }
}
