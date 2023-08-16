namespace Dominio;
public class Matricula : BaseEntityB
{
    public string ? IdPersona { get; set; }
    public Persona ? Persona { get; set; }
    public string ? IdSalon { get; set; }
    public Salon ? Salon { get; set; }
}