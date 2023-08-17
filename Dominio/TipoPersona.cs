namespace Dominio;
public class TipoPersona : BaseEntityB
{
    public string ? DescripcionTipoPersona { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}