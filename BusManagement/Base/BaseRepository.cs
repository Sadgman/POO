using System.Collections.Generic;
using System.Linq;

public class BaseRepository<T> where T : class
{
    protected List<T> _entities = new List<T>();

    public virtual void Actualizar(T entity) { /* Implementación */ }
    public virtual void Agregar(T entity) => _entities.Add(entity);
    public virtual T ObtenerPorId(int id) => null;
    public virtual void Remover(T entity) => _entities.Remove(entity);
    public virtual List<T> TraerTodos() => _entities;
}