public abstract class FiguraGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public abstract double CalcularArea();
}

public class Rectangulo : FiguraGeometrica
{
    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

public class Cuadrado : Rectangulo
{
    public double Lado { get; set; }

    public Cuadrado(double lado)
    {
        Base = lado;
        Altura = lado;
    }
}

class Program
{
    static void Main()
    {
        FiguraGeometrica rectangulo = new Rectangulo { Base = 5, Altura = 3 };
        FiguraGeometrica cuadrado = new Cuadrado { Lado = 4 };

        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());
    }
}
