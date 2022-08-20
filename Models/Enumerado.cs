namespace PolloRapiApi.Models
{
    public class Enumerado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Valor { get; set; }
        //  public Enumerado? Padre { get; set; }

        //public ICollection<Enumerado>? Hijo { get; set; }
        public ICollection<EnumeradoJerarquia>? Ancestros { get; set; }
        public ICollection<EnumeradoJerarquia>? Descendientes { get; set; }
    }
}
