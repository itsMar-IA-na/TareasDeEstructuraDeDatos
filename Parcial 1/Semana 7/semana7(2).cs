using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    // Función recursiva para resolver las Torres de Hanoi
    static void Hanoi(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino,
                      char nombreOrigen, char nombreAuxiliar, char nombreDestino)
    {
        if (n > 0)
        {
            // Mover n-1 discos al auxiliar
            Hanoi(n - 1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);

            // Mover el disco restante al destino
            int disco = origen.Pop();
            destino.Push(disco);

            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");

            // Mover los n-1 discos desde auxiliar al destino
            Hanoi(n - 1, auxiliar, origen, destino, nombreAuxiliar, nombreOrigen, nombreDestino);
        }
    }

    static void Main()
    {
        int numDiscos = 3;

        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        // Inicializa la torre A con los discos
        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        Console.WriteLine("Pasos para resolver las Torres de Hanoi:\n");

        Hanoi(numDiscos, torreA, torreB, torreC, 'A', 'B', 'C');
    }
}
