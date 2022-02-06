using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;


namespace BytebankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com IO. Inicio do programa");
            Console.WriteLine();

            var linhas = File.ReadAllLines("contas.txt");
            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }


            Console.WriteLine();
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {

            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(int.Parse(agencia), int.Parse(numero));
            resultado.Depositar(double.Parse(saldo) - 100);
            resultado.Titular = titular;
            return resultado;
        }

        static void testaLeitura()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);
                    Console.WriteLine();
                    Console.WriteLine(contaCorrente.Titular.Nome);
                    Console.WriteLine(contaCorrente);
                    //Console.WriteLine(linha);
                }
            }

        }


    }
}

