using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Microservices.Monolithic.MVC.Models
{
    public class Order
    {
        [DisplayName("¿De qué dirección debemos recoger el paquete?")]
        public string AddressFrom { get; set; }
        [DisplayName("¿A qué dirección debemos entregar el paquete?")]
        public string AddressTo { get; set; }
        [DisplayName("Peso del paquete")]
        public int Weight { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("El precio de su paquete es")]
        public int Price { get; set; }
    }
}
