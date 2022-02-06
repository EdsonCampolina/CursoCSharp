using Projeto_01.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double CalcularBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
