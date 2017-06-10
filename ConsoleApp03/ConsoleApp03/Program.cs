using System;
using System.Collections.Generic;


namespace ConsoleApp03
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<String> fila = new Queue<string>();
            fila.Enqueue("Maria");
            fila.Enqueue("Paulo");
            fila.Enqueue("Junior");
            fila.Enqueue("Ana");
            while (fila.Count > 0)
            {
                var nome = fila.Dequeue();
                Console.WriteLine(nome);
            }


            Stack<String> pilha = new Stack<string>();
            pilha.Push("Prato 1");
            pilha.Push("Prato 2");
            pilha.Push("Prato 3");
            pilha.Push("Prato 4");
            pilha.Push("Prato 5");

            while (pilha.Count > 0)
            {
                var prato = pilha.Pop();
                Console.WriteLine(prato);
            }

            ArrayList lista = new ArrayList();
            lista.Insert(0, "Item 0");
            lista.Insert(1, "Item 1");
            lista.Insert(2, "Item 2");
            lista.Insert(3, "Item 3");
            lista.Insert(4, "Item 4");
            lista.Insert(2, "INTRUSO");

            for (int i = 0; i < lista.Count; i++)
            {
                var item = lista[i];
                Console.WriteLine(item);
            }




            Console.ReadLine();
        }
    }

   
}