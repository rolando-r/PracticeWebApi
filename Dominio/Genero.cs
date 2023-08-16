namespace Dominio;
public class Genero : BaseEntityB
{
    public string ? Descripcion { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}