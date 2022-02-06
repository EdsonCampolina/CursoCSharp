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
            Console.WriteLine("Trabalhando com o while!");
            int numeroPar = 0;
            Boolean isPar = false;
            while (isPar == false) {
                Console.WriteLine("Digite um número par: ");
                numeroPar = int.Parse(Console.ReadLine());
                if (numeroPar % 2 == 0) {
                    Console.WriteLine("O número "+numeroPar+ " é par!");
                    isPar = true;
                }
            }
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
