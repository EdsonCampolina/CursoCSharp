using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// Define um Funcionario Desenvolvedor do banco ByteBank
    /// </summary>
    public class Desenvolvedor : Funcionario
    {
        /// <summary>
        /// Cria um novo Desenvolvedor a partir dos argumentos passados
        /// </summary>
        /// <param name="cpf">CPF do Desenvolvedor</param>
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
        }
        /// <summary>
        /// Aumenta o salário de um Desenvolvedor
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }
        /// <summary>
        /// Calcula e retorna a bonificação de um Desenvolvedor
        /// </summary>
        /// <returns>Retorna a bonificação</returns>
        internal protected override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
