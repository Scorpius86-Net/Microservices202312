using System.Collections.Generic;
using System.Threading.Tasks;
using Microservices.gRPC.API.Data;
using Microservices.gRPC.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservices.gRPC.API.Data.Repositories
{
    public class ProductRepository
    {
        private readonly StoreDbContext _dbContext;

        public ProductRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public Task<Product> GetOne(int id)
        {
            return _dbContext.Products.SingleAsync(p => p.Id == id);
        }
    }
}
