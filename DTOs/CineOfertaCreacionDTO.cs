using System.ComponentModel.DataAnnotations;

namespace EFCorePeliculas.DTOs
{
    public class CineOfertaCreacionDTO
    {
        [Range(1,100)] //esto permite que el campo acepte solo valores del 1 al 100
        public decimal PorcentajeDescuento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        
    }
}
