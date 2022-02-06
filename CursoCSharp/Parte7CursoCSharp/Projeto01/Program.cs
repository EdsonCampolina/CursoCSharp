using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inicio do programa.");


            testaArrays();


            Console.WriteLine();
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }

        public static void testaArrays() {
            var rand = new Random();
            int[] idades = new int[5];

            for (int i = 0; i < idades.Length; i++)
            {
                idades[i] = 72 / (i + 1);
                Console.WriteLine("Valor atual do vetor idades = " + idades[i]);
            }

            Console.WriteLine("Calculando média...");
            double media = 0;
            int[] arrayMedia = new int[10];
            for (int i = 0; i < arrayMedia.Length; i++)
            {
                arrayMedia[i] = rand.Next(10);
                Console.WriteLine("Valor do arrayMedia na posição " + i + " é igual a " + arrayMedia[i]);
                media += arrayMedia[i];
            }
            media /= (double)arrayMedia.Length;
            Console.WriteLine("Valor da média é igual a " + media);
        }
    }
}
