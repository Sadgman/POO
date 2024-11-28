using DB.Domain.Entidades;

namespace DB.Domain.Interfaces
{
    public interface ITaxiRepository
    {
        void Add(Taxi taxi);
        Taxi GetById(int id);
        IEnumerable<Taxi> GetAll();
        void Update(Taxi taxi);
        void Delete(int id);
    }
}