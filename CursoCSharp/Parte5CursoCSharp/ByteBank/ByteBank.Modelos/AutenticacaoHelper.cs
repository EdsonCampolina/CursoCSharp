using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Classe para auxiliar a autenticação dos Funcionário Autenticáveis
    /// </summary>
    class AutenticacaoHelper
    {
        public static bool ComparaSenhas(string senhaVerdadeira, string senhaTentativa) => senhaVerdadeira == senhaTentativa;
        
    }
}
