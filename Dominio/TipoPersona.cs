namespace Dominio;
public class TipoPersona : BaseEntityB
{
    public string ? Descripcion { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}