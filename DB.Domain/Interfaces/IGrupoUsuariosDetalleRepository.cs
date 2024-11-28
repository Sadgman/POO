using DB.Domain.Entidades;

namespace DB.Domain.Interfaces { 
    public interface IGrupoUsuariosDetalleRepository { 
        void Add(GrupoUsuariosDetalle grupoUsuariosDetalle); 
        GrupoUsuariosDetalle GetById(int id); 
        IEnumerable<GrupoUsuariosDetalle> GetAll(); 
        void Update(GrupoUsuariosDetalle grupoUsuariosDetalle); 
        void Delete(int id); 
    } 
}