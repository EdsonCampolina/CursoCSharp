

using System;

namespace _5_Projeto
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        private int _agencia;
        public int Conta { get; set; }
        private double _saldo = 100;
        public static int TotalDeContas { get; private set; }

        public ContaCorrente(int agencia, int conta, Cliente titular)
        {
            this.Titular = titular;
            this._agencia = agencia;
            this.Conta = conta;

            TotalDeContas++;
        }
        public int Agencia
        {
            get
            {
                return this._agencia;
            }
            set
            {
                if (value > 0)
                {
                    this._agencia = value;
                }
            }
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

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;

        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Tranferir(ContaCorrente conta, double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            conta.Depositar(valor);
            return true;
        }
    }

}
