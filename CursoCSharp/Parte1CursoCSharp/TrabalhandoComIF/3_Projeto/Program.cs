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

            Console.WriteLine("Testando o escopo");
            Boolean aleatorio = true;
            String teste = "Teste";

            if (aleatorio == true) {
                // String saudacao = "Olá";
                teste = "Olá";
            } else {
                //String despedida = "Tchau";
                teste = "Tchau";
            }
            //Console.WriteLine(saudacao);  // erro pois está declarada no if. n existe nesse contexto
            Console.WriteLine(teste);


            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }
    }
}
