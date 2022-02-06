

using System;

namespace _4_Projeto
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int NumeroAgencia { get; set; }
        public int Conta { get; set; }
        private double _saldo = 100;


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
