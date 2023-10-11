using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            //modelBuilder.Entity<Pelicula>().Property(prop => prop.FechaEstreno)
            //    .HasColumnType("date");

            builder.Property(prop => prop.FechaEstreno)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}
