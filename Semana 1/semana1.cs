using System;

// Clase Circulo representa una figura geométrica con un radio
// El atributo radio es de tipo double (tipo de dato primitivo)
public class Circulo
{
    // Encapsulamos el atributo usando private
    private double radio;

    // Constructor para inicializar el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea es una función que devuelve un valor double
    // Calcula el área del círculo usando la fórmula π * r^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro es una función que devuelve un valor double
    // Calcula el perímetro del círculo usando la fórmula 2 * π * r
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase Rectangulo representa un rectángulo con base y altura
// Ambos atributos son de tipo double (tipo de dato primitivo)
public class Rectangulo
{
    // Atributos encapsulados (private)
    private double baseRectangulo;
    private double altura;

    // Constructor que permite inicializar base y altura
    public Rectangulo(double baseRectangulo, double altura)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    // CalcularArea calcula el área del rectángulo: base * altura
    public double CalcularArea()
    {
        return baseRectangulo * altura;
    }

    // CalcularPerimetro calcula el perímetro del rectángulo: 2*(base + altura)
    public double CalcularPerimetro()
    {
        return 2 * (baseRectangulo + altura);
    }
}

// Clase principal que ejecuta el programa
public class Program
{
    public static void Main(string[] args)
    {
        // Creamos un círculo con radio 5
        Circulo c = new Circulo(5);

        // Creamos un rectángulo con base 4 y altura 6
        Rectangulo r = new Rectangulo(4, 6);

        // Mostramos los resultados en pantalla
        Console.WriteLine("=== CÍRCULO ===");
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        Console.WriteLine("\n=== RECTÁNGULO ===");
        Console.WriteLine("Área: " + r.CalcularArea());
        Console.WriteLine("Perímetro: " + r.CalcularPerimetro());
    }
}