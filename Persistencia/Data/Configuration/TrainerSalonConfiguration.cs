using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration 
{
    public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
    {
        public void Configure(EntityTypeBuilder<TrainerSalon> builder)
        {
            builder.ToTable("trainersalon");

            builder.Property(p => p.IdPerTrainerFk)
            .HasMaxLength(20);

            builder.Property(p => p.IdPerTrainerFk)
            .HasColumnType("int");

            builder.HasOne(p => p.Persona)
            .WithMany(p => p.TrainerSalones)
            .HasForeignKey(p => p.IdPerTrainerFk);

            builder.HasOne(p => p.Salon)
            .WithMany(p => p.TrainerSalones)
            .HasForeignKey(p => p.IdPerTrainerFk);
        }
    }
}