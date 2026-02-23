using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        // Universo: 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        // 75 vacunados Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add($"Ciudadano {i}");
        }

        // 75 vacunados AstraZeneca (50 distintos + 25 repetidos)
        HashSet<string> astraZeneca = new HashSet<string>();
        for (int i = 51; i <= 125; i++)
        {
            astraZeneca.Add($"Ciudadano {i}");
        }

        // Operaciones de conjuntos
        var vacunados = pfizer.Union(astraZeneca);
        var noVacunados = ciudadanos.Except(vacunados);
        var ambasDosis = pfizer.Intersect(astraZeneca);
        var soloPfizer = pfizer.Except(astraZeneca);
        var soloAstra = astraZeneca.Except(pfizer);

        // Resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count());
        Console.WriteLine("Ciudadanos con ambas dosis: " + ambasDosis.Count());
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count());
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count());

        // Opcional: mostrar algunos ejemplos
        Console.WriteLine("\nNo vacunados:");
        foreach (var c in noVacunados.Take(10))
            Console.WriteLine(c);

        Console.WriteLine("\nAmbas dosis:");
        foreach (var c in ambasDosis.Take(10))
            Console.WriteLine(c);
    }
}

