using DB.Domain.Entidades;

namespace DB.Domain.Interfaces {
    public interface IUsuarioRepository {
        void Add(Usuario usuario);
        Usuario GetById(int id);
        IEnumerable<Usuario> GetAll();
        void Update(Usuario usuario);
        void Delete(int id);
    } 
}