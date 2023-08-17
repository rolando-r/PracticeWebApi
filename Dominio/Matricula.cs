namespace Dominio;
public class Matricula : BaseEntityB
{
    public string ? IdPersonaFk { get; set; }
    public Persona ? Persona { get; set; }
    public string ? IdSalonFk { get; set; }
    public Salon ? Salon { get; set; }
}