using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Genero
{
    [Key]
    public int IdGenero { get; set; }
    public string ? DescripcionGenero { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}