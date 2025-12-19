using System;

namespace AgendaTelefonica
{
    // Registro / Estructura
    struct Contacto
    {
        public string Nombre;
        public string Telefono;
        public string Correo;
        public int Grupo; // 0 = Familia, 1 = Amigos, 2 = Trabajo
    }

    class Program
    {
        static Contacto[] agenda = new Contacto[10]; // Vector
        static int contador = 0;

        static string[,] grupos =   // Matriz
        {
            { "Familia", "Contactos familiares" },
            { "Amigos", "Contactos de amistad" },
            { "Trabajo", "Contactos laborales" }
        };

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== AGENDA TELEFÓNICA ===");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarContacto();
                        break;
                    case 2:
                        MostrarContactos();
                        break;
                    case 3:
                        BuscarContacto();
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);
        }

        static void AgregarContacto()
        {
            if (contador >= agenda.Length)
            {
                Console.WriteLine("Agenda llena.");
                return;
            }

            Contacto nuevo;

            Console.Write("Nombre: ");
            nuevo.Nombre = Console.ReadLine();

            Console.Write("Teléfono: ");
            nuevo.Telefono = Console.ReadLine();

            Console.Write("Correo: ");
            nuevo.Correo = Console.ReadLine();

            Console.WriteLine("Grupo: 0-Familia | 1-Amigos | 2-Trabajo");
            nuevo.Grupo = int.Parse(Console.ReadLine());

            agenda[contador] = nuevo;
            contador++;

            Console.WriteLine("Contacto agregado correctamente.");
        }

        static void MostrarContactos()
        {
            Console.WriteLine("\n--- LISTADO DE CONTACTOS ---");

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                Console.WriteLine($"Correo: {agenda[i].Correo}");
                Console.WriteLine($"Grupo: {grupos[agenda[i].Grupo, 0]}");
                Console.WriteLine("---------------------------");
            }
        }

        static void BuscarContacto()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string buscar = Console.ReadLine();

            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (agenda[i].Nombre.Equals(buscar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nContacto encontrado:");
                    Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                    Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                    Console.WriteLine($"Correo: {agenda[i].Correo}");
                    Console.WriteLine($"Grupo: {grupos[agenda[i].Grupo, 0]}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }
}
