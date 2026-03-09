using System;
using System.Collections.Generic;

class TorneoFutbol
{
    static void Main()
    {
        // HashSet para almacenar jugadores sin duplicados
        HashSet<string> jugadores = new HashSet<string>();

        // Dictionary para asociar equipos con sus jugadores
        Dictionary<string, List<string>> equipos = new Dictionary<string, List<string>>();

        int opcion;

        do
        {
            Console.WriteLine("\n=== SISTEMA DE TORNEO DE FUTBOL ===");
            Console.WriteLine("1. Registrar equipo");
            Console.WriteLine("2. Registrar jugador en un equipo");
            Console.WriteLine("3. Ver equipos y jugadores");
            Console.WriteLine("4. Ver lista de jugadores registrados");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese nombre del equipo: ");
                    string equipo = Console.ReadLine();

                    if (!equipos.ContainsKey(equipo))
                    {
                        equipos[equipo] = new List<string>();
                        Console.WriteLine("Equipo registrado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("El equipo ya existe.");
                    }
                    break;

                case 2:
                    Console.Write("Ingrese nombre del jugador: ");
                    string jugador = Console.ReadLine();

                    Console.Write("Ingrese equipo al que pertenece: ");
                    string equipoJugador = Console.ReadLine();

                    if (!equipos.ContainsKey(equipoJugador))
                    {
                        Console.WriteLine("El equipo no existe.");
                    }
                    else
                    {
                        // HashSet evita duplicados
                        if (jugadores.Add(jugador))
                        {
                            equipos[equipoJugador].Add(jugador);
                            Console.WriteLine("Jugador registrado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("El jugador ya fue registrado.");
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("\n=== Equipos y Jugadores ===");

                    foreach (var item in equipos)
                    {
                        Console.WriteLine("\nEquipo: " + item.Key);

                        foreach (var j in item.Value)
                        {
                            Console.WriteLine("- " + j);
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("\n=== Jugadores Registrados ===");

                    foreach (var j in jugadores)
                    {
                        Console.WriteLine(j);
                    }
                    break;

                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 5);
    }
}