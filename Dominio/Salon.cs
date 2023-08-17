namespace Dominio;
public class Salon : BaseEntityB
{
    public string ? NombreSalon { get; set; }
    public int CapacidadSalon { get; set; }
    public ICollection<Matricula> ? Matriculas { get; set; }
    public ICollection<TrainerSalon> ? TrainerSalones { get; set; }
}