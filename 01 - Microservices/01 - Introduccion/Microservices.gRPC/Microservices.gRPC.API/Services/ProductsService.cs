using Grpc.Core;
using Microservices.gRPC.API.Data;
using Microservices.gRPC.API.Protos;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.gRPC.API.Services
{    
    public class ProductsService : Products.ProductsBase
    {
        private StoreDbContext _storeDbContext = null;

        public ProductsService(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }
        public override Task<ListResponse> List(Empty request, ServerCallContext context)
        {
            ListResponse listResponse = new ListResponse();
            var query = from p in _storeDbContext.Products
                        select new ProductDto
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Description = p.Description
                        };

            listResponse.Products.AddRange(query.ToList());

            return Task.FromResult(listResponse);
        }

        public override Task<GetByIdResponse> GetById(GetByIdRequest request, ServerCallContext context)
        {
            GetByIdResponse getByIdResponse = new GetByIdResponse();

            var query = from p in _storeDbContext.Products
                        where p.Id == request.Id
                        select new ProductDto
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Description = p.Description
                        };
            getByIdResponse.Product = query.FirstOrDefault();

            return Task.FromResult(getByIdResponse);
        }

        public override Task<Empty> Insert(InsertRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> Update(UpdateRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Empty());
        }
        public override Task<Empty> Delete(DeleteRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Empty());
        }
    }
}
