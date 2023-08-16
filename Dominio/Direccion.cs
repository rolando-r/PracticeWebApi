namespace Dominio;
public class Direccion : BaseEntityA
{
    public string ? TipoVia { get; set; }
    public int Numero { get; set; }
    public string ? Letra { get; set; }
    public string ? SufijoCardinal { get; set; }
    public int NroViaSecundaria { get; set; }
    public string ? LetraViaSecundaria { get; set; }
    public string ? SufijoCards { get; set; }
    public string ? IdPersona { get; set; }
    public Persona ? Persona { get; set; }
}