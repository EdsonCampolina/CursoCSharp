using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com o FOR -> Gerando matriz!");
            int matriz ;
            Random randNum = new Random();
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    int resultado = randNum.Next(30);
                    Console.Write("[" + i + "][" + j + "]->"+ resultado+ " ");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
