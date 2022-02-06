using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Interface que define o que as classes Autenticáveis devem implementar
    /// </summary>
    public interface IAutenticavel
    {
        /// <summary>
        /// Método para verificar se a senha inserida é igual a senha do Objeto
        /// </summary>
        /// <param name="senha">Senha tentativa</param>
        /// <returns></returns>
        bool Autenticar(string senha);
    }
}
