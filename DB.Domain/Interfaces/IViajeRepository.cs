using DB.Domain.Entidades;

namespace DB.Domain.Interfaces {
    public interface IViajeRepository
    {
        void Add(Viaje viaje);
        Viaje GetById(int id);
        IEnumerable<Viaje> GetAll();
        void Update(Viaje viaje);
        void Delete(int id);
    }
}