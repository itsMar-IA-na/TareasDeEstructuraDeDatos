using System;

class Curso
{
    private string[] asignaturas;

    // Constructor
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
    }

    // Método para mostrar las asignaturas
    public void MostrarAsignaturas()
    {
        Console.WriteLine("Asignaturas del curso:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("- " + asignatura);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Curso curso = new Curso();
        curso.MostrarAsignaturas();
    }
}
