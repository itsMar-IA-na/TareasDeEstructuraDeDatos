using System;
using System.Globalization;

class Curso
{
    private string[] asignaturas;
    private double[] notas;

    public Curso()
    {
        asignaturas = new string[]
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        notas = new double[asignaturas.Length];
    }

    // Método para pedir notas (int o float, hasta 2 decimales)
    public void PedirNotas()
    {
        for (int i = 0; i < asignaturas.Length; i++)
        {
            bool notaValida = false;

            while (!notaValida)
            {
                Console.Write("Ingresa la nota de " + asignaturas[i] + ": ");
                string entrada = Console.ReadLine();

                // Reemplaza coma por punto para evitar errores regionales
                entrada = entrada.Replace(',', '.');

                if (double.TryParse(
                        entrada,
                        NumberStyles.AllowDecimalPoint,
                        CultureInfo.InvariantCulture,
                        out double nota))
                {
                    // Redondear a máximo 2 decimales
                    notas[i] = Math.Round(nota, 2);
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Usa números enteros o decimales (ej: 8 o 7.25)");
                }
            }
        }
    }

    // Mostrar resultados
    public void MostrarNotas()
    {
        Console.WriteLine("\nResultados:");
        for (int i = 0; i < asignaturas.Length; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]:0.##}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Curso curso = new Curso();
        curso.PedirNotas();
        curso.MostrarNotas();
    }
}