using System.Collections.Generic;

public interface IAsientoRepository
{
    void Actualizar(Asiento asiento);
    void Agregar(Asiento asiento);
    Asiento ObtenerPorId(int asientoId);
    void Remover(Asiento asiento);
    List<Asiento> TraerTodos();
}
