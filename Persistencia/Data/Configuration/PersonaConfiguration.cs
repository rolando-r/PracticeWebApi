using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            builder.HasKey(e => e.IdCod);
            builder.Property(e => e.IdCod)
            .HasMaxLength(20);

            builder.Property(e => e.NombrePersona)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Genero)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdGenero);

            builder.HasOne(p => p.Ciudad)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdCiudad);

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoPersona);
        }
    }
}