using System;
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
            Console.WriteLine("Trabalhando com o Break");
            Console.WriteLine("Interrompendo impressão de 0 a 9 com o break!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    Console.WriteLine("Utilizando o break!");
                    break;
                }
            }
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
