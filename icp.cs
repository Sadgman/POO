interface IVolar
{
    void Volar();
}

interface ICantar
{
    void Cantar();
}

interface IPonerHuevos
{
    void PonerHuevos();
}

interface INadar
{
    void Nadar();
}

interface ICazar
{
    void Cazar();
}

public class Aguila : IVolar, ICantar, IPonerHuevos, ICazar
{
    public void Volar()
    {
        Console.WriteLine("El águila vuela alto.");
    }

    public void Cantar()
    {
        Console.WriteLine("El águila emite un potente grito.");
    }

    public void PonerHuevos()
    {
        Console.WriteLine("El águila pone huevos en un nido.");
    }

    public void Cazar()
    {
        Console.WriteLine("El águila caza presas.");
    }
}

public class Pingüino : INadar, IPonerHuevos
{
    public void Nadar()
    {
        Console.WriteLine("El pingüino nada en el agua.");
    }

    public void PonerHuevos()
    {
        Console.WriteLine("El pingüino pone huevos en un nido.");
    }
}

public class Avestruz : IPonerHuevos, ICazar
{
    public void PonerHuevos()
    {
        Console.WriteLine("El avestruz pone huevos grandes.");
    }

    public void Cazar()
    {
        Console.WriteLine("El avestruz busca alimento en el suelo.");
    }
}

public class Zoo
{
    public void MostrarHabilidades(IAve ave)
    {
        if (ave is IVolar)
        {
            ((IVolar)ave).Volar();
        }

        if (ave is INadar)
        {
            ((INadar)ave).Nadar();
        }

        if (ave is ICantar)
        {
            ((ICantar)ave).Cantar();
        }

        if (ave is IPonerHuevos)
        {
            ((IPonerHuevos)ave).PonerHuevos();
        }

        if (ave is ICazar)
        {
            ((ICazar)ave).Cazar();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aguila aguila = new Aguila();
        Pingüino pingüino = new Pingüino();
        Avestruz avestruz = new Avestruz();

        Zoo zoo = new Zoo();
        zoo.MostrarHabilidades(aguila);
        zoo.MostrarHabilidades(pingüino);
        zoo.MostrarHabilidades(avestruz);
    }
}