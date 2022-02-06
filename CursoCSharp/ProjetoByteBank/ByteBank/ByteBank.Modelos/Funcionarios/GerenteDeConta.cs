using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// Define um Funcionário Gerente de Conta do banco ByteBank
    /// </summary>
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        /// <summary>
        /// Cria um Gerente de Conta do banco ByteBank
        /// </summary>
        /// <param name="cpf">CPF do Gerente de Conta</param>
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }
        /// <summary>
        /// Aumenta o salário do Gerente de Conta
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        /// <summary>
        /// Calcula e retorna a bonificação de um Gerente de Conta
        /// </summary>
        /// <returns>Retorna a bonificação</returns>
        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
