using System;
using System.Collections.Generic;

class Numeros
{
    private List<int> listaNumeros;

    public Numeros()
    {
        listaNumeros = new List<int>();

        // Almacenar números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            listaNumeros.Add(i);
        }
    }

    public void MostrarInverso()
    {
        listaNumeros.Reverse();

        for (int i = 0; i < listaNumeros.Count; i++)
        {
            Console.Write(listaNumeros[i]);

            if (i < listaNumeros.Count - 1)
            {
                Console.Write(", ");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Numeros numeros = new Numeros();
        numeros.MostrarInverso();
    }
}
