using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define um ParceiroComercial do banco ByteBank
    /// </summary>
    public class ParceiroComercial : IAutenticavel
    {
        // Deixei o metodo como static pra n ter que ficar declarando objeto toda hora
        //private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        /// <summary>
        /// Senha do Parceiro Comercial
        /// </summary>
        public string Senha { get; set; }
        /// <summary>
        /// Verifica se a senha inserida é igual a senha do Parceiro Comercial
        /// </summary>
        /// <param name="senha">Senha a ser verificada</param>
        /// <returns></returns>
        public bool Autenticar(string senha)
        {
            return AutenticacaoHelper.ComparaSenhas(Senha, senha); 
        }
    }
}