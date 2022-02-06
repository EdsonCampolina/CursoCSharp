using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public Funcionario(string cpf, double salario)
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }
        public abstract void AumentarSalario();
        public abstract double CalcularBonificacao();
    }
}
