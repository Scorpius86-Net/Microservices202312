using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.gRPC.API.Data;
using Microservices.gRPC.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservices.gRPC.API.Data.Repositories
{
    public class ProductReviewRepository
    {
        private readonly StoreDbContext _dbContext;

        public ProductReviewRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ProductReview>> GetForProduct(int productId)
        {
            return await _dbContext.ProductReviews.Where(pr => pr.ProductId == productId).ToListAsync();
        }

        public async Task<ILookup<int, ProductReview>> GetForProducts(IEnumerable<int> productIds)
        {
            var reviews = await _dbContext.ProductReviews.Where(pr => productIds.Contains(pr.ProductId)).ToListAsync();
            return reviews.ToLookup(r => r.ProductId);
        }
    }
}
