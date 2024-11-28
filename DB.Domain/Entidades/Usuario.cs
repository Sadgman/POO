using DB.Domain.Base;

namespace DB.Domain.Entidades { 
    public class Usuario : BaseEntity { 
        public int Documento { get; set; } 
        public string Nombre { get; set; } 
        public string Apellido { get; set; } 
    } 
}