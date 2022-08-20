namespace PolloRapiApi.Models
{
    public class Comprobante
    {
        public int Id { get; set; }

        public int? MedioPagoId { get; set; }
        public Enumerado MedioPago { get; set; }
        public int? TipoDocumentoId { get; set; }
        public Enumerado TipoDocumento { get; set; }

    }
}
