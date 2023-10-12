using System.ComponentModel.DataAnnotations;

namespace EFCorePeliculas.DTOs
{
    public class CineCreacionDTO
    {
        [Required]
        public string Nombre { get; set; }
        public double Latitud {  get; set; }
        public double Longitud { get; set; }
        public CineOfertaCreacionDTO CineOfertaCreacionDTO { get; set; }
        public SalaDeCineCreacionDTO[] SalasDeCine {  get; set; }
    }
}
