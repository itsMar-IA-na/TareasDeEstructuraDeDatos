using System;

namespace EstructurasLineales
{
    // Nodo base para todas las estructuras
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

    // ================== LISTA ENLAZADA ==================
    class ListaEnlazada
    {
        private Nodo cabeza;

        public void InsertarFinal(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo aux = cabeza;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevo;
            }
        }

        public void Mostrar()
        {
            Nodo aux = cabeza;
            Console.Write("Lista: ");
            while (aux != null)
            {
                Console.Write(aux.Dato + " -> ");
                aux = aux.Siguiente;
            }
            Console.WriteLine("null");
        }

        public void Eliminar(int dato)
        {
            if (cabeza == null) return;

            if (cabeza.Dato == dato)
            {
                cabeza = cabeza.Siguiente;
                return;
            }

            Nodo aux = cabeza;
            while (aux.Siguiente != null && aux.Siguiente.Dato != dato)
            {
                aux = aux.Siguiente;
            }

            if (aux.Siguiente != null)
            {
                aux.Siguiente = aux.Siguiente.Siguiente;
            }
        }
    }

    // ================== PILA (STACK) ==================
    class Pila
    {
        private Nodo cima;

        public void Push(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            nuevo.Siguiente = cima;
            cima = nuevo;
        }

        public void Pop()
        {
            if (cima == null)
            {
                Console.WriteLine("Pila vacía.");
                return;
            }

            Console.WriteLine("Elemento eliminado: " + cima.Dato);
            cima = cima.Siguiente;
        }

        public void Mostrar()
        {
            Nodo aux = cima;
            Console.Write("Pila: ");
            while (aux != null)
            {
                Console.Write(aux.Dato + " -> ");
                aux = aux.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    // ================== COLA (QUEUE) ==================
    class Cola
    {
        private Nodo frente;
        private Nodo final;

        public void Enqueue(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (final == null)
            {
                frente = final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public void Dequeue()
        {
            if (frente == null)
            {
                Console.WriteLine("Cola vacía.");
                return;
            }

            Console.WriteLine("Elemento eliminado: " + frente.Dato);
            frente = frente.Siguiente;

            if (frente == null)
                final = null;
        }

        public void Mostrar()
        {
            Nodo aux = frente;
            Console.Write("Cola: ");
            while (aux != null)
            {
                Console.Write(aux.Dato + " -> ");
                aux = aux.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    // ================== PROGRAMA PRINCIPAL ==================
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            Pila pila = new Pila();
            Cola cola = new Cola();

            int opcion;

            do
            {
                Console.WriteLine("\n===== MENÚ ESTRUCTURAS LINEALES =====");
                Console.WriteLine("1. Insertar en Lista Enlazada");
                Console.WriteLine("2. Eliminar de Lista Enlazada");
                Console.WriteLine("3. Mostrar Lista");
                Console.WriteLine("4. Push en Pila");
                Console.WriteLine("5. Pop en Pila");
                Console.WriteLine("6. Mostrar Pila");
                Console.WriteLine("7. Enqueue en Cola");
                Console.WriteLine("8. Dequeue en Cola");
                Console.WriteLine("9. Mostrar Cola");
                Console.WriteLine("0. Salir");

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese dato: ");
                        lista.InsertarFinal(int.Parse(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("Ingrese dato a eliminar: ");
                        lista.Eliminar(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        lista.Mostrar();
                        break;

                    case 4:
                        Console.Write("Ingrese dato: ");
                        pila.Push(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        pila.Pop();
                        break;

                    case 6:
                        pila.Mostrar();
                        break;

                    case 7:
                        Console.Write("Ingrese dato: ");
                        cola.Enqueue(int.Parse(Console.ReadLine()));
                        break;

                    case 8:
                        cola.Dequeue();
                        break;

                    case 9:
                        cola.Mostrar();
                        break;
                }

            } while (opcion != 0);
        }
    }
}
