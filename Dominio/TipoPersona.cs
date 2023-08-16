using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class TipoPersona
{
    [Key]
    public int IdTipoPersona { get; set; }
    public string ? DescripcionTipoPersona { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}