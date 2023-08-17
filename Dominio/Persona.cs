namespace Dominio;
public class Persona : BaseEntityA
{
    public string ? NombrePersona { get; set; }
    public string ? Apellido { get; set; }
    public string ? IdGeneroFk { get; set; }
    public Genero ? Genero { get; set; }
    public string ? IdCiudadFk { get; set; }
    public Ciudad ? Ciudad { get; set; }
    public string ? IdTipoPerFk { get; set; }
    public TipoPersona ? TipoPersona { get; set; }
    public ICollection<Matricula> ? Matriculas { get; set; }
    public ICollection<TrainerSalon> ? TrainerSalones { get; set; }
    public ICollection<Direccion> ? Direcciones { get; set; }
}