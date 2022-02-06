using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public int Conta { get; }
        public int Agencia { get; }
        private double _saldo = 100;
        public static int TotalDeContas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public ContaCorrente(int agencia, int conta, Cliente titular)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O número da agência deve ser maior do que 0.", nameof(agencia));
            }
            if (conta <= 0)
            {
                throw new ArgumentException("O número da conta deve ser maior do que 0.", nameof(conta));
            }
            this.Titular = titular;
            Agencia = agencia;
            Conta = conta;
            TotalDeContas++;
            TaxaOperacao = 30 / TotalDeContas;
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value >= 0)
                {
                    this._saldo = value;
                }
            }
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Não é possível sacar valores iguais ou inferiores a 0", nameof(valor));
            }
            if (this._saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            this._saldo -= valor;


        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Tranferir(ContaCorrente conta, double valor)
        {
            if (this._saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                // throw new ArgumentException("Você não tem saldo para tranferir esse valor", nameof(valor));
                throw new SaldoInsuficienteException(Saldo, valor, conta.Conta);
            }
            this._saldo -= valor;
            conta.Depositar(valor);
        }
    }
}
