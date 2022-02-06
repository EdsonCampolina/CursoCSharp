using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando variáveis
            Console.WriteLine("Segundo projeto do curso - Variáveis");
            int idade = 20;
            String nome = "Edson";
            Console.WriteLine("O usuário " + nome + " possui " + idade + " anos de idade.");
            int numero1 = 5, numero2 = 10;
            int soma = numero1 + numero2 * 3;
            Console.WriteLine("Resultado da soma é igual a " + soma);
            Console.WriteLine("Fim do programa. Tecle enter para finalizar...");
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Contador é igual a " + contador);
            }
            Console.ReadLine();
        }
    }
}
