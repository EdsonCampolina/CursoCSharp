using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Funcionarios
{
    class Auxiliar : Funcionario
    {

        public Auxiliar(string cpf) : base(cpf, 2000)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double CalcularBonificacao()
        {
            return Salario * 0.2;
        }
    }
    
    }

