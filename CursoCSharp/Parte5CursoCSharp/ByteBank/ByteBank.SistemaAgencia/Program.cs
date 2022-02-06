using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa...");


            DateTime data = new DateTime(2021, 12, 01);
            DateTime agora = DateTime.Now;

            TimeSpan diferenca = agora - data;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            
    
            Console.WriteLine(diferenca);
            Console.WriteLine(mensagem);


            Console.WriteLine("Finalizando programa...");
            Console.ReadLine();
        }
        
    }
}
