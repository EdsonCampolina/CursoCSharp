using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial Recursivo");
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de " + numero + " é igual a " + Fatorial(numero));
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }

        static int Fatorial(int num)
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }
            return num * Fatorial(num - 1);


        }

    }
}
