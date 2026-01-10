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

    // Método para mostrar el mensaje solicitado
    public void MostrarAsignaturas()
    {
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("Yo estudio " + asignatura);
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
