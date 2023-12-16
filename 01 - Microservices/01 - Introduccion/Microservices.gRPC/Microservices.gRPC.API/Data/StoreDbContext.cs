using Microservices.gRPC.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservices.gRPC.API.Data
{
    public class StoreDbContext: DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {           
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
    }
}
