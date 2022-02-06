using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define um gerenciador de bonificações do banco ByteBank
    /// </summary>
    public class GerenciadorBonificacao
    {
        /// <summary>
        /// Calcula o valor total de bonificações do banco ByteBank
        /// </summary>
        private double _totalBonificacao;
        /// <summary>
        /// Registra a bonificação de um Funcionário do banco ByteBank
        /// </summary>
        /// <param name="funcionario"></param>
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        /// <summary>
        /// Retorna o valor de todas as bonificações
        /// </summary>
        /// <returns>Retorna <see cref="_totalBonificacao"/></returns>
        internal double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
