namespace Dominio;
public class Pais : BaseEntityA
{
    public string ? NombrePais { get; set; }
    public ICollection<Departamento> ? Departamentos { get; set; }
}