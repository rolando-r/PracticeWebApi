using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Salon
{
    [Key]
    public int IdSalon { get; set; }
    public string ? NombreSalon { get; set; }
    public int CapacidadSalon { get; set; }
    public ICollection<Matricula> ? Matriculas { get; set; }
    public ICollection<TrainerSalon> ? TrainerSalones { get; set; }
}