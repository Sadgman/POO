using DB.Domain.Entidades;

namespace DB.Domain.Interfaces
{
    public interface IDetalleViajeRepository
    {
        void Add(DetalleViaje detalleViaje);
        DetalleViaje GetById(int id);
        IEnumerable<DetalleViaje> GetAll();
        void Update(DetalleViaje detalleViaje);
        void Delete(int id);
    }
}