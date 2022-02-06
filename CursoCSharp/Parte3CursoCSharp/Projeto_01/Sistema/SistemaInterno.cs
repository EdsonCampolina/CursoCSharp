using Projeto_01.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01.Sistema
{
    class SistemaInterno
    {
        public bool Login(IAutenticavel usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Usuário logado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }


    }
}
