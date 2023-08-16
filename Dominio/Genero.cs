namespace Dominio;
public class Genero : BaseEntityB
{
    public string ? DescripcionGenero { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}