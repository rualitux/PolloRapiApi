using PolloRapiApi.Data.Enum;

namespace PolloRapiApi.Models
{
    public class ProductoPromocion
    {
        public int ProductoPromocionId { get; set; }
        public int ProductoId { get; set; }
        public int PromocionId { get; set; }
        public Estado Estado { get; set; }
        public Producto Producto { get; set; }
        public Promocion Promocion { get; set; }
    }
}
