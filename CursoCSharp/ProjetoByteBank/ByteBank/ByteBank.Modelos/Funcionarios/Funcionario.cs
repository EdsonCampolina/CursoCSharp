using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// Define um Funcionario do banco ByteBank
    /// </summary>
    public abstract class Funcionario
    {
        /// <summary>
        /// Número de funcionários do banco ByteBank
        /// </summary>
        public static int TotalDeFuncionarios { get; private set; }
        /// <summary>
        /// Nome do funcionário do banco ByteBank
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// CPF do funcionário do banco ByteBank
        /// </summary>
        public string CPF { get; private set; }
        /// <summary>
        /// Salario do funcionário do banco ByteBank
        /// </summary>
        public double Salario { get; protected set; }
        /// <summary>
        /// Cria um Funcionário do banco ByteBank
        /// </summary>
        /// <param name="salario"><see cref="Salario"/> do funcionpario</param>
        /// <param name="cpf"><see cref="CPF"/> do funcionario</param>
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }
        /// <summary>
        /// Aumenta o salário do Funcionário
        /// </summary>
        public abstract void AumentarSalario();
        /// <summary>
        /// Calcula e retorna o salario do Funcionário
        /// </summary>
        /// <returns>salario do Funcionário</returns>
        protected internal abstract double GetBonificacao();
    }
}
