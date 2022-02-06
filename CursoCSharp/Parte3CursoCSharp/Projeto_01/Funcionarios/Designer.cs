using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Funcionarios
{
    class Designer : Funcionario
    {
        private string v;


        public Designer(string cpf) : base(cpf,3000)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
        public override double CalcularBonificacao()
        {
            return Salario * 0.17;
        }
    }
    
    
}
