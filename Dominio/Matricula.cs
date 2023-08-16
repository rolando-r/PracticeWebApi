using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Matricula
{
    [Key]
    public int IdMatricula { get; set; }
    public string ? IdPersonaFk { get; set; }
    public Persona ? Persona { get; set; }
    public string ? IdSalonFk { get; set; }
    public Salon ? Salon { get; set; }
}