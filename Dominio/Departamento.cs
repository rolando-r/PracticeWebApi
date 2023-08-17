namespace Dominio;
public class Departamento : BaseEntityA
{
    public string ? NombreDep { get; set; }
    public string ? IdPaisFk { get; set; }
    public Pais ? Pais { get; set; }
    public ICollection<Ciudad> ? Ciudades { get; set; }
}