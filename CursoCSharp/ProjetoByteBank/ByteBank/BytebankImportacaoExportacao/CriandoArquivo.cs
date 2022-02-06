using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {

                var contaComoString = "456,78945,4785.50,Edson Campolina";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);
                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }
        }

        static void CriarArquivoComWriter()
        {

            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {

                escritor.Write("123,65781,2000.0,Edson SIlva");

            }

        }

        static void TestaFlush()
        {
            var caminhoArquivo = "teste.txt";
            Random rand = new Random();

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                int soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    int num = rand.Next(30);
                    soma += num;
                    Console.WriteLine("Rand = " + num);
                    escritor.WriteLine($"Escrevendo no arquivo. Linha {i}");
                    escritor.WriteLine("Número randômico igual a " + num);
                    escritor.Flush();
                    Console.WriteLine("Linhas foram escritas no arquivo... Tecle enter para continuar.");
                    Console.ReadLine();
                }
                escritor.WriteLine("A soma total dos números é igual a " + soma);

            }



        }
    }
}
