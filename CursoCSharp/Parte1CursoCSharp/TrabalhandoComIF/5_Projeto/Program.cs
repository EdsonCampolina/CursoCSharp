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
            /*
             * Restaurante com 3 comdias (Pizza, sanduiche, cachorro quente) 
             */
            Console.WriteLine("Trabalhando com switch!");
            int comida;
            do
            {
                Console.WriteLine("Escolha a sua comida:");
                Console.WriteLine("Opções: 1)Pizza  2)Sanduche  3)Cachorro Quente");
                comida = int.Parse(Console.ReadLine());
                switch (comida)
                {
                    case 1:
                        Console.WriteLine("Você escolheu uma pizza!");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu um sanduíche!");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu um cachorro quente!");
                        break;
                    default:
                        Console.WriteLine("Digite o número da refeição que você deseja pedir!");
                        break;

                }
            } while (comida != 1 && comida != 2 && comida != 3);
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
