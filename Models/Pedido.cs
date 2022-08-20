using System.ComponentModel.DataAnnotations;

namespace PolloRapiApi.Models
{
    public class Pedido
    {

        public int Id { get; set; }

        [DataType(DataType.Date)]

        public DateTime Fecha { get; set; }

        [DataType(DataType.Time)]

        public DateTime Hora { get; set; }

        public int EnumeradoId { get; set; }

        public Enumerado? Estado { get; set; }

    }
}

