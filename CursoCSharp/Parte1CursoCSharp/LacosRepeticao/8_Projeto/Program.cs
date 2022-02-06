using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial com FOR");
            int fatorial = int.Parse(Console.ReadLine()), resultado=1;
            if (fatorial == 0)
                resultado = 1;
            else {
                for (int i = 1; i <= fatorial; i++)
                {
                    resultado *= i;
                }
            }
            Console.WriteLine(resultado);
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
