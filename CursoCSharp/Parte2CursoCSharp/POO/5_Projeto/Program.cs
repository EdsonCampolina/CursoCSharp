using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com Construtores e membros estáticos");
            Cliente cliente = new Cliente();
            ContaCorrente conta = new ContaCorrente(1034, 128, cliente);
            ContaCorrente conta2 = new ContaCorrente(1034, 128, cliente);
            ContaCorrente conta3 = new ContaCorrente(1034, 128, cliente);
            ContaCorrente conta4 = new ContaCorrente(1034, 128, cliente);
            Console.WriteLine(conta.Agencia);

            conta.Agencia = -100;
            Console.WriteLine(conta.Agencia);

            Console.WriteLine(ContaCorrente.TotalDeContas);

            Console.WriteLine();
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
