using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// Define um Funcionário Designer do Banco ByteBank
    /// </summary>
    public class Designer : Funcionario
    {
        /// <summary>
        /// Cria um Designer a partir dos argumentos utilizados
        /// </summary>
        /// <param name="cpf">CPF do Designer</param>
        public Designer(string cpf) : base(3000, cpf)
        {
        }
        /// <summary>
        /// Aumenta o salário do Designer
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
        /// <summary>
        /// Calcula e retorna a bonificação do Designer
        /// </summary>
        /// <returns>Retorna a bonificação do Designer</returns>
        internal protected override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
