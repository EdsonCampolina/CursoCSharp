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
            Console.WriteLine("Implementando funções nas classes!");

            ContaCorrente contaEdson = new ContaCorrente(), contaJunior = new ContaCorrente();
            contaEdson.titular = "Edson";
            Console.WriteLine(contaEdson.saldo);
            Console.WriteLine("Tentativa de sacar 200 Reais:");
            Console.WriteLine(contaEdson.Sacar(200));
            Console.WriteLine(contaEdson.saldo);
            Console.WriteLine("Tentativa de sacar 200 Reais:");
            Console.WriteLine(contaEdson.Sacar(200));
            Console.WriteLine(contaEdson.saldo);
            contaEdson.Depositar(5000);
            Console.WriteLine(contaEdson.saldo);

            contaJunior.titular = "Junior";
            Console.WriteLine("Saldo do Junior");
            Console.WriteLine(contaJunior.saldo);

            Console.WriteLine(contaEdson.Tranferir(contaJunior, 500));
            Console.WriteLine(contaEdson.saldo);
            Console.WriteLine(contaJunior.saldo);


            Console.WriteLine();
            Console.WriteLine("Fim do programa!");
            Console.ReadLine();
        }
    }
}
