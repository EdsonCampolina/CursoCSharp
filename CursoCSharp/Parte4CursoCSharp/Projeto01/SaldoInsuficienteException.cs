using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    public class SaldoInsuficienteException : Exception
    {

        public double Saldo { get; }
        public double ValorSaque { get; }

        public double ValorTransferencia { get; }

        public int NumContaTransferencia { get; }

        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(double saldo, double valor, int numContaTransferencia) : this("Tentativa de transferência de " + valor + " para a conta de numero " + numContaTransferencia+". Saldo insuficiente!")
        {
            Saldo = saldo;
            ValorTransferencia = valor;
            NumContaTransferencia = numContaTransferencia;
        }
        public SaldoInsuficienteException(string messagem) : base(messagem)
        {

        }

    }

}





