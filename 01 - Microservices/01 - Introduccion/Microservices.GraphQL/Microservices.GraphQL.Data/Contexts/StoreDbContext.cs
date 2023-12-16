using Microservices.GraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservices.GraphQL.Data.Contexts
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
    }
}
