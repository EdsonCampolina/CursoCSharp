

using System;

namespace _3_Projeto
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int numeroAgencia;
        public int numeroConta;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            if (this.saldo < 100)
            {
                return false;
            }
            this.saldo -= valor;
            return true;

        }
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Tranferir(ContaCorrente conta, double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            conta.Depositar(valor);
            return true;
        }
    }

}
