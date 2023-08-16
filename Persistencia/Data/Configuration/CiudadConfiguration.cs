using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("ciudad");

            builder.HasKey(e => e.IdCod);
            builder.Property(e => e.IdCod)
            .HasMaxLength(3);

            builder.Property(p => p.NombreCiudad)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Departamento)
            .WithMany(p => p.Ciudades)
            .HasForeignKey(p => p.IdDep);
        }
    }
}