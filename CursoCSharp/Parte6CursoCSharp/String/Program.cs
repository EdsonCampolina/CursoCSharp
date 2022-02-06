using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com Strings");

            string teste = "Bom dia, ola, como você está";

            Console.WriteLine(teste.Contains("ola"));
            Console.WriteLine(teste.Contains("praca"));
            Console.WriteLine(teste.StartsWith("ola"));
            Console.WriteLine(teste.StartsWith("Bom dia"));
            Console.WriteLine(teste.EndsWith("está"));
            Console.WriteLine(teste.EndsWith("esta"));



            string padrao ="[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string textoDeTeste = "Numero de telefone é igual 0007-9876";
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));



            string padrao2 ="[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string textoDeTeste2 = "Numero de telefone é igual 0007-9876";

            Match resultado2 = Regex.Match(textoDeTeste2, padrao2);
            Console.WriteLine(resultado2.Value);



            string padrao3 ="[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            string textoDeTeste3 = "Numero de telefone é igual 0007-9876";

            Match resultado3 = Regex.Match(textoDeTeste3, padrao3);
            Console.WriteLine(resultado3.Value);



            string padrao4 = "[0-9]{4}[-][0-9]{4}";
            string textoDeTeste4 = "Numero de telefone é igual 0007-9876";

            Match resultado4 = Regex.Match(textoDeTeste4, padrao4);
            Console.WriteLine(resultado4.Value);



            string padrao5 = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string textoDeTeste5 = "Numero de telefone é igual 90007-9876";
            string textoDeTeste51 = "Numero de telefone é igual 0007-9876";
            string textoDeTeste52 = "Numero de telefone é igual 00079876";

            Match resultado5 = Regex.Match(textoDeTeste5, padrao5);
            Match resultado51 = Regex.Match(textoDeTeste51, padrao5);
            Match resultado52 = Regex.Match(textoDeTeste52, padrao5);
            Console.WriteLine(resultado5.Value);
            Console.WriteLine(resultado51.Value);
            Console.WriteLine(resultado52.Value);



            string padrao6 = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string textoDeTeste6 = "Numero de telefone é igual 90007-9876";
            string textoDeTeste61 = "Numero de telefone é igual 900079876";
            Match resultado6 = Regex.Match(textoDeTeste6, padrao6);
            Match resultado61 = Regex.Match(textoDeTeste61, padrao6);
            Console.WriteLine(resultado6.Value);
            Console.WriteLine(resultado61.Value);



            string padrao7 = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste7 = "Numero de telefone é igual 90007-9876";
            string textoDeTeste71 = "Numero de telefone é igual 90007--9876";
            Match resultado7 = Regex.Match(textoDeTeste7, padrao7);
            Match resultado71 = Regex.Match(textoDeTeste71, padrao7);
            Console.WriteLine(resultado7.Value);
            Console.WriteLine(resultado71.Value);// Nesse caso não pega então tera uma linha em branco a mais
            Console.WriteLine("NAO PEGOU");
            


            Console.WriteLine();
            Console.WriteLine("Fim do programa...");
            Console.ReadLine();

        }
    }
}
