using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        /// <summary>
        /// Retorna o tamanho da lista
        /// </summary>
        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        /// <summary>
        /// Instancia um objeto ListaDeContaCorrente, passando como argumento opcional sua capacidade inicial
        /// </summary>
        /// <param name="capacidadeInicial">Tamanho da lista</param>
        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;

        }
        /// <summary>
        /// Adiciona itens na Lista
        /// </summary>
        /// <param name="item"></param>
        public void Adicionar(ContaCorrente item)
        {
            if (_proximaPosicao >= _itens.Length)
            {
                VerificaCapacidade(_itens.Length + 1);
            }
            Console.WriteLine("Adicionando item na posição " + _proximaPosicao);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }
        /// <summary>
        /// Verifica o tamanho da lista e se for menordo que precisa, aumenta o tamanho da lista
        /// </summary>
        /// <param name="tamanho"></param>
        private void VerificaCapacidade(int tamanho)
        {
            if (_itens.Length < tamanho)
            {
                Console.WriteLine("Aumentando o tamanho do array.....");

                ContaCorrente[] novoArray = new ContaCorrente[tamanho];
                for (int i = 0; i < +_itens.Length; i++)
                {
                    novoArray[i] = _itens[i];
                }
                _itens = novoArray;
            }
        }
        /// <summary>
        /// Remove a ContaCorrente passada como argumento
        /// </summary>
        /// <param name="contaRemover">ContaCorrente a ser removida</param>
        public void Remover(ContaCorrente contaRemover)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(contaRemover))
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
            Console.WriteLine("Item removido.");
        }
        /// <summary>
        /// Imprime os itens da ListaDeContaCorrente
        /// </summary>
        public void ImprimeLista()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine($"Conta Corrente no índice {i} tem Agência de número {_itens[i].Agencia} e Conta de número {_itens[i].Numero}.");
            }

        }
        /// <summary>
        /// Retorna a ContaCorrente que está na posição informada
        /// </summary>
        /// <param name="indice">Posição da lista</param>
        /// <returns></returns>
        public ContaCorrente GetContaCorrenteNoIndice(int indice)
        {
            if (indice < 0)
            {
                throw new ArgumentOutOfRangeException("Indice não pode ser negativo.", nameof(indice));
            }
            return _itens[indice];
        }
        /// <summary>
        /// Indexador que retorna a ContaCorrente que está na posição informada
        /// </summary>
        /// <param name="indice">Posição da lista</param>
        /// <returns></returns>
        public ContaCorrente this[int indice]
        {
            get
            {
                return GetContaCorrenteNoIndice(indice);
            }
        }
        /// <summary>
        /// Adiciona várias Contas Correntes de uma só vez
        /// </summary>
        /// <param name="contasAdicionar">Array de ContaCorrente</param>
        public void AdicionarVarias(params ContaCorrente[] contasAdicionar)
        {
            //for (int i = 0; i < contasAdicionar.Length; i++)
            //{
            //    this.Adicionar(contasAdicionar[i]);
            //}
            foreach (ContaCorrente conta in contasAdicionar)
            {
                Adicionar(conta);
            }
        }
    }
}
