using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Pais
{
    [Key]
    public string ? IdPais { get; set; }
    public string ? NombrePais { get; set; }
    public ICollection<Departamento> ? Departamentos { get; set; }
}