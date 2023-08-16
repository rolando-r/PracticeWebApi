using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration 
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            builder.ToTable("tipopersona");

            builder.HasKey(e => e.IdCod);
            builder.Property(e => e.IdCod);

            builder.Property(p => p.DescripcionTipoPersona)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}