using DB.Domain.Entidades;

namespace DB.Domain.Interfaces
{
    public interface IGrupoUsuariosRepository
    {
        void Add(GrupoUsuarios grupoUsuarios);
        GrupoUsuarios GetById(int id);
        IEnumerable<GrupoUsuarios> GetAll();
        void Update(GrupoUsuarios grupoUsuarios);
        void Delete(int id);
    }
}