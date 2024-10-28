using System;

namespace HerenciaPolimorfismo
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}");
        }

        public int CalcularEdadEnAnios()
        {
            return Edad;
        }
    }

    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula)
            : base(nombre, edad, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        public void MostrarInformacionCompleta()
        {
            MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}, Matrícula: {Matricula}");
        }
    }

    public abstract class Figura
    {
        public abstract double CalcularArea();
    }

    public class Rectangulo : Figura{
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto){
            Ancho = ancho;
            Alto = alto;
        }

        public override double CalcularArea(){
            return Ancho * Alto;
        }
    }
    public class Circulo : Figura{
        public double Radio { get; set; }

        public Circulo(double radio){
            Radio = radio;
        }

        public override double CalcularArea(){
            return Math.PI * Radio * Radio;
        }
    }

    public class Triangulo : Figura{
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseTriangulo, double altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }

    class Program{
        static void Main(string[] args)
        {
            Persona persona = new Persona("Ana", 25, "Cartago");
            persona.MostrarInformacion();
            Estudiante estudiante = new Estudiante("Juan", 20, "San José", "Informática", "20210001");
            estudiante.MostrarInformacionCompleta();
            Figura rectangulo = new Rectangulo(5, 10);
            Figura circulo = new Circulo(7);
            Figura triangulo = new Triangulo(6, 8);

            Console.WriteLine($"Área del Rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Área del Círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Área del Triángulo: {triangulo.CalcularArea()}");
        }
    }
}