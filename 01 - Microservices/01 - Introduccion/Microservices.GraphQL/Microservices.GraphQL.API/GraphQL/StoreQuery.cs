using Microservices.GraphQL.Data.Entities;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;
using Microservices.GraphQL.Data.Contexts;

namespace Microservices.GraphQL.API.GraphQL
{
    public class StoreQuery
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IEnumerable<Product> GetProducts([Service] StoreDbContext dbContext)
        {
            return dbContext.Products;
        }

    }
}
