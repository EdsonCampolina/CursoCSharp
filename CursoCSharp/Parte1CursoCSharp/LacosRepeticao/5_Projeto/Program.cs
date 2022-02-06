using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com o break em um laço de repetição!");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) {
                    if (j >= i)
                    {
                        break;
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Fim do programa!");
            Console.ReadLine();
        }
    }
}
