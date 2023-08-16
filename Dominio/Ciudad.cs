namespace Dominio;
public class Ciudad : BaseEntityA
{
    public string ? NombreCiudad { get; set; }
    public string ? IdPais { get; set; } 
    public string ? IdDep { get; set; }
    public Departamento ? Departamento { get; set; }
    public ICollection<Persona> ? Personas { get; set; }
}