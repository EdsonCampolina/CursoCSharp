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
            ContaCorrente contaEdson = new ContaCorrente(), contaJunior = new ContaCorrente();
            contaEdson.titular = "Edson";
            contaEdson.numeroAgencia = 183;
            contaEdson.numeroConta = 1234;
            contaEdson.saldo = 1000.70;
            contaJunior.titular = "Edson";
            contaJunior.numeroAgencia = 183;
            contaJunior.numeroConta = 1234;
            contaJunior.saldo = 1500.93;

            Console.WriteLine("Titular: "+contaEdson.titular);
            Console.WriteLine("Numero da agência: "+ contaEdson.numeroAgencia);
            Console.WriteLine("Numero da conta: "+contaEdson.numeroConta);
            Console.WriteLine("Saldo: "+contaEdson.saldo);

            contaEdson.saldo += 500.23;

            Console.WriteLine("Titular: " + contaEdson.titular);
            Console.WriteLine("Numero da agência: " + contaEdson.numeroAgencia);
            Console.WriteLine("Numero da conta: " + contaEdson.numeroConta);
            Console.WriteLine("Saldo: " + contaEdson.saldo);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tipos de referência e tipos de valor;");
            int num1=10, num2=10;
            Console.WriteLine("Duas variáveis com mesmo valor quando comparadas = "+ (num1==num2));
            Console.WriteLine("Dois objetos com mesmo valor quando comparados = " + (contaEdson == contaJunior));
            Console.WriteLine("Isso acontece pois a referência deles não é igual!");


            Console.WriteLine();
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
