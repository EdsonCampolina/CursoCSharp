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
        /// <summary>
        /// Implementação do método Equals do Cliente
        /// </summary>
        /// <param name="obj">Objeto a ser comparado</param>
        /// <returns>Retorna true se forem iguais e false se não forem iguais</returns>
        public override bool Equals(object obj)
        {
            //Cliente outroCliente = (Cliente)cliente;
            Cliente outroCliente = obj as Cliente;
            return outroCliente == null
                ? false
                : (CPF == outroCliente.CPF) && (Nome == outroCliente.Nome) && (Profissao == outroCliente.Profissao);
        }
    }
}
