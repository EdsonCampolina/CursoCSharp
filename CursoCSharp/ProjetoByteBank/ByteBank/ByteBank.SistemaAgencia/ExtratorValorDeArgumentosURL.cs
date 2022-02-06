using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    /// <summary>
    /// Classe para extrair os argumentos de uma URL
    /// </summary>
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        /// <summary>
        /// URL a ser tratada pelo ExtratorDeArgumentosURL
        /// </summary>
        public string URL { get; }
        /// <summary>
        /// Cria um ExtratorValorDeArgumentosURL
        /// </summary>
        /// <param name="url"></param>
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento não pode ser nulo ou vazio.", nameof(url));
            }
            URL = url;
            _argumentos = url.Substring(url.IndexOf('?') + 1);
        }
        /// <summary>
        /// Retorna o valor do argumento inserido a partir da URL inserida no construtor
        /// </summary>
        /// <param name="valor">Valor a ser procurado </param>
        /// <returns>Retorna o Valor a partir do argumento</returns>
        public string GetValor(string valor)
        {
            string urlConvertida = URL.ToUpper();
            valor += "=";
            string valorChecagem = valor.ToUpper();
            if (urlConvertida.Substring(urlConvertida.IndexOf(valorChecagem) + valorChecagem.Length).IndexOf('&') == -1)
                return URL.Substring(URL.IndexOf(valor) + valor.Length);
            else
                return URL.Substring(URL.IndexOf(valor) + valor.Length).Remove(URL.Substring(URL.IndexOf(valor) + valor.Length).IndexOf('&'));
        }
    }
}
