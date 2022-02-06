using Projeto_01.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Funcionarios
{
    class GerenteDeConta : FuncionarioAutenticavel 
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        public override double CalcularBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
