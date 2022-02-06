using Projeto_01.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Sistema
{
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);


    }
}
