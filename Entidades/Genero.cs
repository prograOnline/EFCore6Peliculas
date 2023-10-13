

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePeliculas.Entidades
{
    ///[Table("TablaGeneros",Schema ="peliculas")]
    public class Genero
    {
        public int Identificador { get; set; }
        //[StringLength(150)]
        //[MaxLength(150)]
        //[Required]
        public string Nombre { get; set; }
        public bool EstaBorrado { get; set; }
        public HashSet<Pelicula>? Peliculas { get; set; }

    }
}
