using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com o for para imprimir a tabuada!");
            for (int i = 1; i <= 10; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" x "+ j+" = "+i * j +"  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
