using Microservices.gRPC.API.Data;
using Microservices.gRPC.API.Data.Repositories;
using Microservices.gRPC.API.Services;
using Microsoft.EntityFrameworkCore;

namespace Microservices.gRPC.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:Microservices.gRPC"]));
            builder.Services.AddScoped<ProductRepository>();
            builder.Services.AddScoped<ProductReviewRepository>();

            builder.Services.AddGrpc(options => { options.EnableDetailedErrors = true; });

            /******************************************************************************************************/

            var app = builder.Build();
                        
            app.MapGrpcService<ProductsService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
            
            SeedData(app);

            app.Run();
        }

        static void SeedData(IHost app)
        {
            var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

            using (var scope = scopedFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<StoreDbContext>();
                dbContext.Seed();
            }
        }
    }
}