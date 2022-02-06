using Projeto_01.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(string CPF, double salario) : base(CPF, salario)
        {

        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
