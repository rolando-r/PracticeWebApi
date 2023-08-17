namespace Dominio;
public class TrainerSalon
{
    public string ? IdPerTrainerFk { get; set; }
    public Persona ? Persona { get; set; }
    public string ? IdSalonFk { get; set; }
    public Salon ? Salon { get; set; }
}