using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Departamento
{
    [Key]
    public string ? IdDep { get; set; }
    public string ? NombreDep { get; set; }
    public string ? IdPaisFk { get; set; }
    public Pais ? Pais { get; set; }
    public ICollection<Ciudad> ? Ciudades { get; set; }
}