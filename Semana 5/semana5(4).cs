using System;
using System.Collections.Generic;

class Loteria
{
    private List<int> numeros;

    public Loteria()
    {
        numeros = new List<int>();
    }

    // Método para pedir los números ganadores
    public void PedirNumeros()
    {
        Console.WriteLine("Ingresa los 6 números ganadores de la lotería primitiva:");

        while (numeros.Count < 6)
        {
            Console.Write($"Número {numeros.Count + 1}: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero) && numero >= 1 && numero <= 49)
            {
                if (!numeros.Contains(numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("❌ El número ya fue ingresado.");
                }
            }
            else
            {
                Console.WriteLine("❌ Ingresa un número válido entre 1 y 49.");
            }
        }
    }

    // Método para ordenar y mostrar los números
    public void MostrarNumerosOrdenados()
    {
        numeros.Sort();

        Console.WriteLine("\nNúmeros ganadores ordenados:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Loteria loteria = new Loteria();
        loteria.PedirNumeros();
        loteria.MostrarNumerosOrdenados();
    }
}
