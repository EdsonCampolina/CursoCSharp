using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// Define um Funcionário Autenticável do banco ByteBank
    /// </summary>
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        // Deixei o metodo como static pra n ter que ficar declarando objeto toda hora
        //private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        /// <summary>
        /// Senha do Funcionário Autenticável do banco ByteBank
        /// </summary>
        public string Senha { get; set; }
        /// <summary>
        /// Cria um Funcionário Autenticável do banco ByteBank
        /// </summary>
        /// <param name="salario">Salario do Funcionário Auteticável</param>
        /// <param name="cpf">CPF do Funcionário Autenticável</param>
        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {
        }
        /// <summary>
        /// Autentica o Funcionário Autenticável do banco ByteBank
        /// </summary>
        /// <param name="senha">Senha a ser comparada com a senha do funcionário</param>
        /// <returns>Retorna "true" se a senha estiver correta e "false" caso ela esteja errada</returns>
        public bool Autenticar(string senha)
        {
            return AutenticacaoHelper.ComparaSenhas(Senha, senha);
        }
    }
}
