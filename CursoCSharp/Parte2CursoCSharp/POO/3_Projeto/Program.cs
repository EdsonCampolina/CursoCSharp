using System;
using _3_Projeto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com namespace");

            Cliente clienteEdson = new Cliente();
            clienteEdson.nome = "Edson";
            clienteEdson.cpf = "000.000.000-00";
            clienteEdson.profissao = "Estudante";
            ContaCorrente contaEdson = new ContaCorrente();
            contaEdson.titular = clienteEdson;
            contaEdson.numeroAgencia = 1234;
            contaEdson.numeroConta = 1234567;
            contaEdson.saldo = 5000;
            Console.WriteLine(contaEdson.titular.nome);
            Console.WriteLine(clienteEdson.nome);
            clienteEdson.nome = "Edson Junior Campolina Silva";
            Console.WriteLine(contaEdson.titular.nome);
            contaEdson.titular.profissao = "Estagiario";
            Console.WriteLine(clienteEdson.profissao);




            Console.WriteLine();
            Console.WriteLine("Fim do programa!");
            Console.ReadLine();
        }
    }
}
