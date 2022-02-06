using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    ///  Define um Funcionario Auxiliar do banco ByteBank
    /// </summary>
    public class Auxiliar : Funcionario
    {
        /// <summary>
        /// Cria um novo funcionário a partir dos argumentos utilizados
        /// </summary>
        /// <param name="cpf">CPF do Auxiliar</param>
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }
        /// <summary>
        /// Aumenta o salário do Auxiliar
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
        /// <summary>
        /// Calcula e retorna o valor da bonificação do Auxiliar
        /// </summary>
        /// <returns>Retorna o valor da bonificação</returns>
        internal protected override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
