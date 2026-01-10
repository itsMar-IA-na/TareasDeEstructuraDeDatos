using System;
using System.Collections.Generic;

class Curso
{
    private List<string> asignaturas;
    private List<double> notas;

    public Curso()
    {
        asignaturas = new List<string>()
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        notas = new List<double>();
    }

    // Pedir las notas al usuario
    public void PedirNotas()
    {
        for (int i = 0; i < asignaturas.Count; i++)
        {
            double nota;
            bool valida = false;

            while (!valida)
            {
                Console.Write("Ingresa la nota de " + asignaturas[i] + ": ");
                string entrada = Console.ReadLine().Replace(',', '.');

                if (double.TryParse(entrada, out nota))
                {
                    notas.Add(nota);
                    valida = true;
                }
                else
                {
                    Console.WriteLine("❌ Ingresa un número válido.");
                }
            }
        }
    }

    // Eliminar asignaturas aprobadas
    public void EliminarAprobadas()
    {
        for (int i = asignaturas.Count - 1; i >= 0; i--)
        {
            if (notas[i] >= 5)
            {
                asignaturas.RemoveAt(i);
                notas.RemoveAt(i);
            }
        }
    }

    // Mostrar asignaturas a repetir
    public void MostrarRepetir()
    {
        Console.WriteLine("\nAsignaturas que debes repetir:");

        if (asignaturas.Count == 0)
        {
            Console.WriteLine("🎉 Ninguna, has aprobado todo.");
        }
        else
        {
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine("- " + asignatura);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Curso curso = new Curso();
        curso.PedirNotas();
        curso.EliminarAprobadas();
        curso.MostrarRepetir();
    }
}
