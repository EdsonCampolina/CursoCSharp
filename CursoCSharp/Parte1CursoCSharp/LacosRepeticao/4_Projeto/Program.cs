using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com while para calcular poupança!");
            int meses = 1;
            double valorAplicado = 1000, porcentagemRendimento = 0.0036 ;

            while (meses<= 12)
            {
                valorAplicado *= (1 +porcentagemRendimento);
                Console.WriteLine("No mês "+meses+ " você possui "+valorAplicado+ " reais!");
                meses++;
            }


            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
