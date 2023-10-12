using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(prop => prop.Nombre)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(prop => prop.Biografia)
                .IsRequired(false);

            builder.Property(prop => prop.FechaNacimiento)
                .IsRequired(false);

            builder.Property(x => x.Nombre).HasField("_nombre");
        }
    }
}
