using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    /// <summary>
    /// Define um Funcionário Estagiário do banco ByteBank
    /// </summary>
    public class Estagiario : Funcionario
    {
        /// <summary>
        /// Cria um Estagiário do banco ByteBank
        /// </summary>
        /// <param name="salario">Salario do Estagiário</param>
        /// <param name="cpf">CPF do estagiário</param>
        public Estagiario(double salario, string cpf) : base(salario, cpf)
        {

        }
        /// <summary>
        /// Aumenta o salário do Estagiário
        /// </summary>
        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Calcula e retorna o valor da bonificação do Estagiário
        /// </summary>
        /// <returns></returns>
        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
