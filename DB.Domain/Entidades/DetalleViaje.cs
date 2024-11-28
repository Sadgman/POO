using DB.Domain.Base;

namespace DB.Domain.Entidades { 
    public class DetalleViaje : BaseEntity { 
        public int Fecha { get; set; } 
        public int Latitude { get; set; } 
        public int Longitude { get; set; } 
        public Viaje Viaje { get; set; } 
    }
}