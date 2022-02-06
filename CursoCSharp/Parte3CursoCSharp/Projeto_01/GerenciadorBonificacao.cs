using Projeto_01.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01
{
    public class GerenciadorBonificacao
    {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.CalcularBonificacao();
        }
        public double getTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
