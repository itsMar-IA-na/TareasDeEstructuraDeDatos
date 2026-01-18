using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;
    private int contador;

    public int Cantidad => contador;

    // Agregar al final
    public void AgregarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
        contador++;
    }

    // Agregar al inicio
    public void AgregarInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
        contador++;
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada listaPrimos = new ListaEnlazada();
        ListaEnlazada listaArmstrong = new ListaEnlazada();

        Console.Write("Ingrese la cantidad de números a evaluar: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());

            if (EsPrimo(num))
            {
                listaPrimos.AgregarFinal(num);
            }

            if (EsArmstrong(num))
            {
                listaArmstrong.AgregarInicio(num);
            }
        }

        // a) Cantidad de datos
        Console.WriteLine("\nCantidad de elementos:");
        Console.WriteLine($"Lista de primos: {listaPrimos.Cantidad}");
        Console.WriteLine($"Lista de Armstrong: {listaArmstrong.Cantidad}");

        // b) Lista con más elementos
        if (listaPrimos.Cantidad > listaArmstrong.Cantidad)
        {
            Console.WriteLine("La lista de números primos contiene más elementos.");
        }
        else if (listaArmstrong.Cantidad > listaPrimos.Cantidad)
        {
            Console.WriteLine("La lista de números Armstrong contiene más elementos.");
        }
        else
        {
            Console.WriteLine("Ambas listas contienen la misma cantidad de elementos.");
        }

        // c) Mostrar datos
        Console.WriteLine("\nLista de números primos:");
        listaPrimos.Mostrar();

        Console.WriteLine("\nLista de números Armstrong:");
        listaArmstrong.Mostrar();
    }

    static bool EsPrimo(int num)
    {
        if (num <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static bool EsArmstrong(int num)
    {
        int original = num;
        int suma = 0;
        int digitos = num.ToString().Length;

        while (num > 0)
        {
            int digito = num % 10;
            suma += (int)Math.Pow(digito, digitos);
            num /= 10;
        }

        return suma == original;
    }
}
