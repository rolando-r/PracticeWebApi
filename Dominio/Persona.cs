namespace Dominio;
public class Persona : BaseEntityA
{
    public string ? Nombre { get; set; }
    public string ? Apellido { get; set; }
    public string ? IdGenero { get; set; }
    public Genero ? Genero { get; set; }
    public string ? IdCiudad { get; set; }
    public Ciudad ? Ciudad { get; set; }
    public string ? IdTipoPersona { get; set; }
    public TipoPersona ? TipoPersona { get; set; }
    public ICollection<Matricula> ? Matriculas { get; set; }
    public ICollection<TrainerSalon> ? TrainerSalones { get; set; }
    public ICollection<Direccion> ? Direcciones { get; set; }
}