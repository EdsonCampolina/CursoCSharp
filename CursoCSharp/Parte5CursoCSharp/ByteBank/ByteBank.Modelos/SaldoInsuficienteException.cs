using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma exceção do caso o saldo para realizar a operação seja insuficiente
    /// </summary>
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        /// <summary>
        /// Saldo da Conta Corrente em que ocorreu essa exceção
        /// </summary>
        public double Saldo { get; }
        /// <summary>
        /// Valor da tentativa do saque
        /// </summary>
        public double ValorSaque { get; }

        /// <summary>
        /// Cria uma execeção do tipo SaldoInsuficienteException
        /// </summary>
        public SaldoInsuficienteException()
        {

        }
        /// <summary>
        /// Cria uma exceção do tipo SaldoInsuficienteException com os argumentos utilizados
        /// </summary>
        /// <param name="saldo"> <see cref="Saldo"/> da Conta Corrente</param>
        /// <param name="valorSaque"><see cref="ValorSaque"/>que tentaram realizar</param>
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        /// <summary>
        /// Define a SaldoInsuficienteException.Message
        /// </summary>
        /// <param name="mensagem">Mensagem a ser definida</param>
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {
        }
        /// <summary>
        /// Define a SaldoInsuficienteException.Message e sua inner Exception
        /// </summary>
        /// <param name="mensagem"> Mensagem a ser definida</param>
        /// <param name="excecaoInterna">Inner Exception</param>
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }
    }

}
