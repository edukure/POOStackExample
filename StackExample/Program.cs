using System;
using System.Collections;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo com Pilha<T> Criado utilizando List<T>");
            Pilha<int> PilhaInt = new Pilha<int>();
            PilhaInt.Push(1);
            PilhaInt.Push(3);
            PilhaInt.Push(5);
            PilhaInt.Push(7);
            PilhaInt.Push(9);
            Console.WriteLine(PilhaInt.ToString());

            Console.WriteLine();
            //Removendo último item colocado
            Console.WriteLine("Removendo último item colocado");
            PilhaInt.Pop();
            Console.WriteLine("Pilha Atualizada:");
            Console.WriteLine(PilhaInt.ToString());
            //PilhaInt.PrintPilha(); outra maneira de printar a pilha

            Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Exemplo de Pilha com a classe Stack do System.Collections"); 

            //Instanciando uma Stack
            Stack Stack = new Stack();
            //Também existe a classe Stack<T> do System.Collections.Generic
            //Apenas Stack recebe objetos de todos os tipos
            //Stack<T> só pode conter objetos do tipo T

            //Adicionando itens à pilha
            Stack.Push(1);
            Stack.Push(3);
            Stack.Push(5);
            Stack.Push(7);
            Stack.Push(9);
            PrintStack(Stack);

            Console.WriteLine();
            //Removendo último item colocado
            Console.WriteLine("Removendo último item colocado");
            Stack.Pop();
            Console.WriteLine("Pilha Atualizada:");
            PrintStack(Stack);

            Console.ReadLine();

        }

        public static void PrintStack(Stack stack)
        {
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
