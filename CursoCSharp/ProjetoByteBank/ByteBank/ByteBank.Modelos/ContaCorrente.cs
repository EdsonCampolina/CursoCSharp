using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma conta corrente do banco ByteBank
    /// </summary>
    public class ContaCorrente : IComparable
    {
        /// <summary>
        /// Taxa de Operação da ContaCorrente
        /// </summary>
        private static int TaxaOperacao;
        /// <summary>
        /// Total de contas criadas no banco ByteBank
        /// </summary>
        public static int TotalDeContasCriadas { get; private set; }
        /// <summary>
        /// Cliente titular da Conta Corrente
        /// </summary>
        public Cliente Titular { get; set; }
        /// <summary>
        /// Conta o número de saques não permitidos na Conta Corrente
        /// </summary>
        public int ContadorSaquesNaoPermitidos { get; private set; }
        /// <summary>
        /// Conta o número de transferências não permitidas na Conta Corrente
        /// </summary>
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        /// <summary>
        /// Número da Conta Corrente
        /// </summary>
        public int Numero { get; }
        /// <summary>
        /// Número da Agência da Conta Corrente
        /// </summary>
        public int Agencia { get; }
        /// <summary>
        /// Saldo da conta corrente
        /// </summary>
        private double _saldo = 100;
        /// <summary>
        /// Get e Set do <see cref="_saldo"/>
        /// </summary>
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        /// <summary>
        /// Cria uma Conta Corrente, com os argumentos especificados
        /// </summary>
        /// <exception cref="ArgumentException" > Lançada quando um valor negativo é utilizado em <paramref name="agencia"/> ou em     <paramref name=" numero"/> </exception>
        /// <param name="agencia">Representa  o valor da propriedade  <see cref="Agencia"/></param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/></param>
        public ContaCorrente(int agencia, int numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        /// <summary>
        /// Saca dinheiro da Conta Corrente 
        /// </summary>
        /// <exception cref="ArgumentException"> Lançada quando <paramref name="valor"/> é menor do que 0</exception>
        /// <exception cref="SaldoInsuficienteException">Lançada quando <paramref name="valor"/> é maior do que o <see cref="Saldo"/>    </exception>
        /// <param name="valor">Valor a ser sacado da Conta Corrente</param>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }
        /// <summary>
        /// Deposita dinheiro na Conta Corrente
        /// </summary>
        /// <param name="valor">Valor a ser depositado na Conta Corrente</param>
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        /// <summary>
        /// Transfere dinheiro de uma Conta Corrente para a outra
        /// </summary>
        /// <exception cref="ArgumentException"> Lançada quando <paramref name="valor"/> é menor do que 0</exception>
        /// <exception cref="SaldoInsuficienteException">Lançada quando <paramref name="valor"/> é maior do que o <see cref="Saldo"/>    </exception>
        /// <param name="valor">Valor a ser transferido</param>
        /// <param name="contaDestino">Conta Corrente a ser depositada o valor</param>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }
        /// <summary>
        /// Implementação do ToString do ContaCorrente
        /// </summary>
        /// <returns>Retorna uma String que ilustra a ContaCorrente</returns>
        public override string ToString()
        {
            return $"Número da conta = {Numero},\nNúmero da Agência = {Agencia},\nSaldo = {Saldo}.";
        }
        /// <summary>
        /// Implementação do Equal do ContaCorrente
        /// </summary>
        /// <param name="obj">ContaCorrente a ser comparada</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            ContaCorrente conta = obj as ContaCorrente;
            if (conta == null)
            {
                return false;
            }
            return conta.Agencia == this.Agencia && conta.Numero == this.Numero;
        }
        /// <summary>
        /// Implementação do CompareTo, que compara o número das Contas
        /// -1 -> A Conta Corrente passada por parâmetro é maior
        /// 00 -> As Contas Correntes são iguais
        /// +1 -> A Conta Corrente passada por parâmetro é menor
        /// </summary>
        /// <param name="obj">Conta Corrente a ser comparada</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            var outraConta = obj as ContaCorrente;
            if (outraConta == null)
                return -1;
            if (Numero < outraConta.Numero)
                return -1;
            else if (Numero == outraConta.Numero)
                return 0;
            return 1;
        }
    }

}
