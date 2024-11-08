using System;

class Program
{
    static void Main(string[] args)
    {
        AsientoRepository asientoRepo = new AsientoRepository();

        Asiento nuevoAsiento = new Asiento
        {
            AsientoId = 1,
            BusId = 100,
            NumeroPiso = 1,
            NumeroAsiento = 15,
            FechaCreacion = DateTime.Now
        };

        asientoRepo.Agregar(nuevoAsiento);
        Console.WriteLine("Asiento agregado.");

        Asiento asiento = asientoRepo.ObtenerPorId(1);
        if (asiento != null)
        {
            Console.WriteLine($"Asiento encontrado: {asiento.AsientoId}");
        }
        else
        {
            Console.WriteLine("Asiento no encontrado.");
        }

        asiento.NumeroAsiento = 16;
        asientoRepo.Actualizar(asiento);
        Console.WriteLine("Asiento actualizado.");

        var asientos = asientoRepo.TraerTodos();
        Console.WriteLine($"Total de asientos: {asientos.Count}");

        asientoRepo.Remover(asiento);
        Console.WriteLine("Asiento removido.");
    }
}
