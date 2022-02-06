using Projeto_01.Funcionarios;
using Projeto_01.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto da terceira parte do curso de CSharp");

            //CalcularBonificacao();
            UsarSistema();


            Console.WriteLine();
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "Senha";


            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

         

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            Console.WriteLine("Total de bonificações é igual a " + gerenciador.getTotalBonificacao());

        }
        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "Senha";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "q1W2e3R4";

            ParceiroComercial edson = new ParceiroComercial();
            edson.Senha = "SenhaDoEdson";

            //sistema.Login(camila, "Senha");
            //sistema.Login(camila, "123");
            //sistema.Login(camila, "q1W2e3R4");

            sistema.Login(edson, "SenhaDoEdson");
            sistema.Login(edson,"123");


        }
    }
}
