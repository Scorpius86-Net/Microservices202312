using System.ComponentModel.DataAnnotations;
namespace Microservices.gRPC.API.Data.Entities
{
    public class ProductReview
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [StringLength(200), Required]
        public string Title { get; set; }
        public string Review { get; set; }
    }
}
