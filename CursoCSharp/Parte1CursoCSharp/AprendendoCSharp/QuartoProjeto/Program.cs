using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quarto projeto - Outros tipos de valores numéricos ");
            // Aceita até 16 bits
            short valor = 20999;
            Console.WriteLine(valor);
            // Aceita até 32 bits
            int idade = 13;
            Console.WriteLine(idade);
            // Aceita até 64 bits
            long longo = 190000000000000;
            Console.WriteLine(longo);
            float altura = 1.78f;
            Console.WriteLine(altura);
            Console.WriteLine("Fim da execução. Tecle enter...");
            Console.ReadLine();
        }
    }
}
