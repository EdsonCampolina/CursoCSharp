using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
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





            Console.WriteLine();
            Console.WriteLine("Finalizando programa...");
            Console.ReadLine();
        }

        static void testaSort()
        {
            var nomes = new List<string>() {
                "Edson",
                "Júnior",
                "Campolina",
                "Silva"
            };

            nomes.Sort();
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }




            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(4);
            lista.Add(7);
            lista.Add(12);
            lista.AdicionarVarios(65, 887, 23, 12, 43, 12, 42, 23, 14, 23);
            lista.AdicionarVarios(99, -1);
            lista.Sort();



            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
        }

        static void testaStrings()
        {
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar&maisUmValor=3442";

            Console.WriteLine("Buscando os três valores:");
            ExtratorValorDeArgumentosURL extratorURLs = new ExtratorValorDeArgumentosURL(url);
            Console.WriteLine(extratorURLs.GetValor("maisUmValor"));
            Console.WriteLine(extratorURLs.GetValor("moedaDestino"));
            Console.WriteLine(extratorURLs.GetValor("moedaOrigem"));


        }
        static void testaEquals()
        {
            ContaCorrente conta = new ContaCorrente(1234, 12345678);
            Console.WriteLine(conta);

            Cliente edson = new Cliente();
            Cliente edson2 = new Cliente();
            edson.CPF = "0000";
            edson.Nome = "Edson";
            edson.Profissao = "Estagiario";
            edson2.CPF = "0000";
            edson2.Nome = "Edson";
            edson2.Profissao = "Estagiario";
            Console.WriteLine(edson.Equals(edson2));
        }

        static void testaArraydeContas()
        {
            ContaCorrente[] arrayContas = new ContaCorrente[] {
                new ContaCorrente(874, 3435433),
                new ContaCorrente(846, 3534523),
                new ContaCorrente(884, 3451243)
            };
            //arrayContas[0] = new ContaCorrente(874, 3435433);
            //arrayContas[1] = new ContaCorrente(846, 3534523);
            //arrayContas[2] = new ContaCorrente(884, 3451243);

            for (int i = 0; i < arrayContas.Length; i++)
            {
                Console.WriteLine($"Conta de índice {i}: Agencia = {arrayContas[i].Agencia} e Numero da Conta = {arrayContas[i].Numero}");
            }

        }

        static void testaLista()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaRemover = new ContaCorrente(999, 9999999);
            ContaCorrente[] arrayContas = new ContaCorrente[] {
                new ContaCorrente(876, 93664523),
                new ContaCorrente(876, 93667625),
                new ContaCorrente(876, 93663413),
                new ContaCorrente(876, 93664325),
                new ContaCorrente(876, 93656823)
                };
            lista.Adicionar(new ContaCorrente(876, 98766254));
            lista.Adicionar(new ContaCorrente(876, 98764434));
            lista.Adicionar(new ContaCorrente(876, 93665523));
            lista.Adicionar(contaRemover);
            lista.AdicionarVarias(arrayContas);
            lista.AdicionarVarias(new ContaCorrente(876, 98766254),
                new ContaCorrente(876, 95132544),
                new ContaCorrente(876, 98766454),
                new ContaCorrente(876, 86516625));
            Console.WriteLine("Lista antes de ter um item removido");
            lista.ImprimeLista();
            lista.Remover(contaRemover);
            Console.WriteLine("Lista após ter um item removido");
            lista.ImprimeLista();
            Console.WriteLine(lista.GetContaCorrenteNoIndice(0).Numero);
        }

        static void parteOitoCursoCSharp()
        {
            var contas = new List<ContaCorrente>()
            {
                    new ContaCorrente(1213, 2412),
                    new ContaCorrente(1123, 12456),
                    new ContaCorrente(1232, 987),
                    new ContaCorrente(1234, 1232)//,null
            };
            contas.Sort();
            contas.Sort(new ComparadorContaCorrentePorAgencia());
            foreach (ContaCorrente item in contas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDENANDO VIA OrderBy conta.Numero");
            Console.WriteLine();

            //IOrderedEnumerable<ContaCorrente> ordenada = contas.OrderBy(conta =>
            //{
            //    if (conta == null)
            //    {

            //        return int.MaxValue;
            //    }
            //    return conta.Numero;
            //});
            IOrderedEnumerable<ContaCorrente> ordenada = contas.OrderBy(conta => conta.Numero);
            foreach (ContaCorrente item in ordenada)
            {
                //if (item != null)
                //{
                Console.WriteLine(item);
                //}
            }


            Console.WriteLine();
            Console.WriteLine("ORDENANDO VIA OrderBy contaDaListaSemNulos.Numero");
            Console.WriteLine();

            var listaSemNulos = new List<ContaCorrente>();

            foreach (var conta in contas)
            {
                if (conta != null)
                {
                    listaSemNulos.Add(conta);
                }
            }
            IOrderedEnumerable<ContaCorrente> ordenadaSemNulos = listaSemNulos.OrderBy(contaDaListaSemNulos => contaDaListaSemNulos.Numero);
            foreach (ContaCorrente item in ordenadaSemNulos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDENANDO VIA OrderBy contaDaListaSemNulos.Numero via Lambdas");
            Console.WriteLine();

            var contasNaoNulas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasNaoNulas)
            {
                Console.WriteLine(conta);
            }
        }
    }

}

