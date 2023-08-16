using Dominio;
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class PracticeWebApiContext : DbContext
    {
        public PracticeWebApiContext(DbContextOptions<PracticeWebApiContext> options) : base(options)
        {
        }
        public DbSet<Ciudad> ? Ciudades { get; set; }
        public DbSet<Persona> ? Personas { get; set; }
        public DbSet<Salon> ? Salones { get; set; }
        public DbSet<Matricula> ? Matriculas { get; set; }
        public DbSet<TipoPersona> ? TipoPersonas { get; set; }
        public DbSet<TrainerSalon> ? TrainerSalones { get; set; }
        public DbSet<Departamento> ? Departamentos { get; set; }
        public DbSet<Pais> ? Paises { get; set; }
        public DbSet<Genero> ? Generos { get; set; }
    }
}