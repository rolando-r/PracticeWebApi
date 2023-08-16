using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("pais");

            builder.HasKey(e => e.IdCod);
            builder.Property(e => e.IdCod)
            .HasMaxLength(3);

            builder.Property(p => p.NombrePais)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}