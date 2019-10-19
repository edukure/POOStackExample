using System;
using System.Collections.Generic;
using System.Text;

namespace StackExample
{
    public class Pilha<T>
    {
        private List<T> Lista { get; set; }
        public T Topo { get; set; }
        public int Count { get; private set; } = 0;


        public Pilha()
        {
            Lista = new List<T>();
        }

        /// <summary>
        /// Remove o item no topo da pilha
        /// </summary>
        public void Pop()
        {
            try
            {
                Lista.RemoveAt(Count - 1);
                Count--;
            }
            catch
            {
                Console.WriteLine("Pilha vazia");
            }
        }
       
        /// <summary>
        /// Adiciona um item ao topo da pilha
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            Lista.Add(item);
            Count++;
            Topo = item;
        }

        public override string ToString()
        {
            StringBuilder itensPilha = new StringBuilder();
            foreach(var item in Lista)
            {
                itensPilha.Insert(0,item.ToString() + '\n');
            }
            return itensPilha.ToString();
        }

        //Maneira alternativa de printar a lista
        public void PrintPilha()
        {
            List<T> listaInvertida = Lista;
            listaInvertida.Reverse();
            listaInvertida.ForEach(item => Console.WriteLine(item));
        }
    }
}
