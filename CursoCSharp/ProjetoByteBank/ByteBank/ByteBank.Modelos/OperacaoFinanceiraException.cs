using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma exceção caso uma operação financeira não seja executada com sucesso
    /// </summary>
    public class OperacaoFinanceiraException : Exception
    {
        /// <summary>
        ///  Cria uma exceção do tipo OperaçãoFinanceiraException
        /// </summary>
        public OperacaoFinanceiraException()
        {

        }
        /// <summary>
        /// Define a OperacaoFinanceiraException.Message
        /// </summary>
        /// <param name="mensagem">Mensagem a ser definida</param>
        public OperacaoFinanceiraException(string mensagem)
            : base(mensagem)
        {

        }
        /// <summary>
        /// Define a OperacaoFinanceiraException.Message e sua innerException
        /// </summary>
        /// <param name="mensagem">Mensagem a ser definida</param>
        /// <param name="excecaoInterna">Inner exception</param>
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }
    }
}
