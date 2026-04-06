using System;
using System.Collections.Generic;

class Programa
{
    // ------------------ GRAFO ------------------
    static void MostrarGrafo(Dictionary<string, List<string>> grafo)
    {
        Console.WriteLine("Representación del Grafo:");
        foreach (var nodo in grafo)
        {
            Console.Write(nodo.Key + " -> ");
            foreach (var vecino in nodo.Value)
            {
                Console.Write(vecino + " ");
            }
            Console.WriteLine();
        }
    }

    // ------------------ ARBOL ------------------
    class Nodo
    {
        public int valor;
        public Nodo izquierda, derecha;

        public Nodo(int valor)
        {
            this.valor = valor;
            izquierda = derecha = null;
        }
    }

    static void InOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            InOrden(raiz.izquierda);
            Console.Write(raiz.valor + " ");
            InOrden(raiz.derecha);
        }
    }

    static void Main()
    {
        // ----------- GRAFO 1 -----------
        var grafo1 = new Dictionary<string, List<string>>()
        {
            {"A", new List<string>{"B","C"}},
            {"B", new List<string>{"D"}},
            {"C", new List<string>{"D"}},
            {"D", new List<string>()}
        };

        // ----------- GRAFO 2 -----------
        var grafo2 = new Dictionary<string, List<string>>()
        {
            {"1", new List<string>{"2","3"}},
            {"2", new List<string>{"4"}},
            {"3", new List<string>()},
            {"4", new List<string>()}
        };

        Console.WriteLine("=== GRAFO 1 ===");
        MostrarGrafo(grafo1);

        Console.WriteLine("\n=== GRAFO 2 ===");
        MostrarGrafo(grafo2);

        // ----------- ARBOL 1 -----------
        Nodo raiz1 = new Nodo(10);
        raiz1.izquierda = new Nodo(5);
        raiz1.derecha = new Nodo(15);

        Console.WriteLine("\n=== ARBOL 1 (InOrden) ===");
        InOrden(raiz1);

        // ----------- ARBOL 2 -----------
        Nodo raiz2 = new Nodo(20);
        raiz2.izquierda = new Nodo(10);
        raiz2.derecha = new Nodo(30);
        raiz2.izquierda.izquierda = new Nodo(5);

        Console.WriteLine("\n\n=== ARBOL 2 (InOrden) ===");
        InOrden(raiz2);
    }
}