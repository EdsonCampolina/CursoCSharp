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
            /*
             O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as regras de alíquota. Ele descobriu no site da receita:
            De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
            De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
            De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636. 
            double salario = 3300.0;
             */

            // Salario
            double salario = 3300.0;
            // IR = Imposto de Renda
            double IR = 0;
            // Dedução maxima por salario
            int deducaoMaxima = 0;
            // Resultado do salario - IR + deducação
            double salarioMaximoReal = 0;

            // IFs para calcular o IR
            if (salario >= 1900.0 && salario <= 2800.0)
            {
                IR = 0.075;
                deducaoMaxima = 142;
            }
            else if (salario >= 2800.01 && salario <= 3751.00)
            {
                IR = 0.15;
                deducaoMaxima = 350;
            }
            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                IR = 0.225;
                deducaoMaxima = 636;
            }

            /*
              Salario máximo que João poderá obter após descontos do governo,
              levando em consideração que ele deduzirá o máximo possível
            */
            salarioMaximoReal = (salario * ((double)1 - IR)) + deducaoMaxima;
            Console.WriteLine("Seu salário real é igual a: "+ salarioMaximoReal);

            Console.WriteLine("Fim do programa...");
            Console.ReadLine();


        }
    }
}
