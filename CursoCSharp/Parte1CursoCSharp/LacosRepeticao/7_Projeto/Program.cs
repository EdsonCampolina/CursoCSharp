using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo multiplos de 3 de 1 a 100 utilizando o FOR");


            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Fim do programa!");
            Console.ReadLine();
        }
    }
}
