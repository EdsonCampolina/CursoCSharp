using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankImportacaoExportacao
{
    partial class Program
    {


        static void EscritaBinaria()
        {

            using (var fs = new FileStream("ContaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456);                     // Agencia
                escritor.Write(1245);                    // Conta
                escritor.Write(2351.56);                 // Saldo
                escritor.Write("Edson Campolina");       // Titular
            }

        }

        static void LeituraBinaria()
        {

            using (var fs = new FileStream("ContaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var conta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine("Realizando a leitura dos binários...");
                Console.WriteLine($"Agencia é igual a {agencia} // Numero da conta é igual a {conta} // Saldo é igual a {saldo} // Titular: {titular}");
                Console.WriteLine("Fim da leitura dos binarios.");

            }

        }

    }


}
