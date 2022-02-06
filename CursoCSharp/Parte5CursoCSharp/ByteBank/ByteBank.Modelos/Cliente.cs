using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define um cliente do banco ByteBank
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Nome do Cliente
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// CPF do Cliente
        /// </summary>
        public string CPF { get; set; }
        /// <summary>
        /// Profissão do Cliente
        /// </summary>
        public string Profissao { get; set; }
    }
}
