using System;

namespace RegistroEstudiante
{
    class Estudiante
    {
        public string ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }

        public Estudiante(string id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            ID = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("===== DATOS DEL ESTUDIANTE =====");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");

            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string id = "0952601367";
            string nombres = "Mariana";
            string apellidos = "López";
            string direccion = "Aloasí, Barrio El Tambo 1";

            string[] telefonos = {
                "0999725735",
                "0984124123",
                "0993169853"
            };

            Estudiante estudiante = new Estudiante(
                id,
                nombres,
                apellidos,
                direccion,
                telefonos
            );

            estudiante.MostrarInformacion();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
