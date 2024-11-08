using System.Linq;

public class AsientoRepository : BaseRepository<Asiento>, IAsientoRepository
{
    public override Asiento ObtenerPorId(int asientoId)
    {
        return _entities.FirstOrDefault(a => a.AsientoId == asientoId);
    }
}