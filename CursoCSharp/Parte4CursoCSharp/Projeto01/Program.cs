using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com Try/Catch");
            Console.WriteLine();

            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("MAIN EX");
            }

            Console.WriteLine("Fim do programa...");
            Console.ReadLine();

        }

        private static void CarregarContas()
        {

            using (LeitorDeArquivo arquivo = new LeitorDeArquivo("contas.txt"))
            {
                arquivo.LerProximaLinha();
            }











            // -------------------- METODO TRY
            //LeitorDeArquivo arquivo = null;
            //try
            //{
            //    arquivo = new LeitorDeArquivo("contas.txt");
            //    arquivo.LerProximaLinha();
            //    arquivo.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Excecao IO");
            //}
            //finally
            //{
            //    if (arquivo != null)
            //        arquivo.Fechar();

            //}
        }

        private static void TestaExceptions()
        {
            Cliente edson = new Cliente();
            ContaCorrente contaTransferida = new ContaCorrente(20, 20, edson);
            try
            {
                ContaCorrente conta = new ContaCorrente(10, 10, edson);
                //conta.Sacar(1000);
                //conta.Sacar(-550);
                conta.Tranferir(contaTransferida, 1000);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine(e.Saldo);
                //Console.WriteLine(e.ValorSaque);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }
        }

    }
}
