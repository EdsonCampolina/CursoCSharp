using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terceiro projeto - Trabalhando com double");

            double preco = 100;
            double desconto = 0.2;
            double precoFinal = preco * (1 - desconto);
            Console.WriteLine("Valor final do produto é igual a " + precoFinal);
            Console.WriteLine("Divisao de 15 por 2");
            int numeroInt = 15;
            double numeroDouble = 15;
            Console.WriteLine("Divisão do numero inteiro 7");
            Console.WriteLine(numeroInt / 2);
            Console.WriteLine("Divisão do numero double 7");
            Console.WriteLine(numeroDouble / 2);
            numeroDouble = 15;
            Console.WriteLine("Segunda execução da divisão do double");
            Console.WriteLine(numeroDouble / 2);
            double numero;
            numero = 15 / 2;
            Console.WriteLine("Numero é igual a " + numero);
            numero = (double)15 / 2;
            Console.WriteLine("Numero é igual a " + numero);
            numero = 15.0 / 2;
            Console.WriteLine("Numero é igual a " + numero);


            Console.WriteLine("Fim do programa. Tecle enter pra finalizar...");
            Console.ReadLine();
        }
    }
}
