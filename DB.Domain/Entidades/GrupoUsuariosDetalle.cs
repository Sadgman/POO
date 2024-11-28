using DB.Domain.Base;

namespace DB.Domain.Entidades { 
    public class GrupoUsuariosDetalle : BaseEntity {
        public int UsuarioId { get; set; } 
        public Usuario Usuario { get; set; } 
        public GrupoUsuarios GrupoUsuarios { get; set; } 
    }  
}