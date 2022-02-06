using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trbalhando com Getters and Setters");
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);
            Cliente cliente = new Cliente();
            conta.Titular = cliente;


            Console.WriteLine();
            Console.WriteLine("Fim do programa!");
            Console.ReadLine();
        }
    }
}
