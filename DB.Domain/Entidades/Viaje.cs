using DB.Domain.Base;

namespace DB.Domain.Entidades { 
    public class Viaje : BaseEntity {
        public int TaxiId { get; set; } 
        public int FechaInicio { get; set; } 
        public int FechaFin { get; set; } 
        public int Desde { get; set; } 
        public int Hasta { get; set; } 
        public int Calificacion { get; set; } 
        public Taxi Taxi { get; set; } 
    } 
}