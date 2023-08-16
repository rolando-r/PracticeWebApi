using System.ComponentModel.DataAnnotations;

namespace Dominio;
public class Direccion
{
    [Key]
    public string ? IdDireccion { get; set; }
    public string ? TipoVia { get; set; }
    public int Numero { get; set; }
    public string ? Letra { get; set; }
    public string ? SufijoCardinal { get; set; }
    public int NroViaSecundaria { get; set; }
    public string ? LetraViaSecundaria { get; set; }
    public string ? SufijoCards { get; set; }
    public string ? IdPersonaFk { get; set; }
    public Persona ? Persona { get; set; }
}