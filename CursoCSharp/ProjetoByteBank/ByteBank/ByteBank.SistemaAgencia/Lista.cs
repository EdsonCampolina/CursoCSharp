using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
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
        private T[] _itens;
        private int _proximaPosicao;
        /// <summary>
        /// Instancia um objeto Lista, passando como argumento opcional sua capacidade inicial
        /// </summary>
        /// <param name="capacidadeInicial">Tamanho da lista</param>
        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;

        }
        /// <summary>
        /// Adiciona itens na Lista
        /// </summary>
        /// <param name="item"></param>
        public void Adicionar(T item)
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
        /// Verifica o tamanho da lista e se for menor do que precisa, aumenta o tamanho da lista
        /// </summary>
        /// <param name="tamanho">Tamanho da lista</param>
        private void VerificaCapacidade(int tamanho)
        {
            if (_itens.Length < tamanho)
            {
                Console.WriteLine("Aumentando o tamanho do array.....");

                T[] novoArray = new T[tamanho];
                for (int i = 0; i < +_itens.Length; i++)
                {
                    novoArray[i] = _itens[i];
                }
                _itens = novoArray;
            }
        }
        /// <summary>
        /// Remove o T passado como argumento
        /// </summary>
        /// <param name="remover">T a ser removido</param>
        public void Remover(T remover)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(remover))
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
            //_itens[_proximaPosicao] = null;
            Console.WriteLine("Item removido.");
        }
        /// <summary>
        /// Imprime os itens da Lista
        /// </summary>
        public void ImprimeLista()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine("Item ");
            }

        }
        /// <summary>
        /// Retorna o T que está na posição informada
        /// </summary>
        /// <param name="indice">Posição da lista</param>
        /// <returns></returns>
        public T GetTNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException("Indice não pode ser negativo.", nameof(indice));
            }
            return _itens[indice];
        }
        /// <summary>
        /// Indexador que retorna o T que está na posição informada
        /// </summary>
        /// <param name="indice">Posição da lista</param>
        /// <returns></returns>
        public T this[int indice]
        {
            get
            {
                return GetTNoIndice(indice);
            }
        }
        /// <summary>
        /// Adiciona vários T de uma só vez
        /// </summary>
        /// <param name="Tadcionar">Array de ContaCorrente</param>
        public void AdicionarVarias(params T[] Tadcionar)
        {
            //for (int i = 0; i < contasAdicionar.Length; i++)
            //{
            //    this.Adicionar(contasAdicionar[i]);
            //}
            foreach (T conta in Tadcionar)
            {
                Adicionar(conta);
            }
        }
    }
}
