using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microservices.GraphQL.Data.Contexts;
using Microservices.GraphQL.API.GraphQL;
using HotChocolate.Execution;
using HotChocolate.Execution.Configuration;

namespace Microservices.GraphQL.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options => options.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));
                        
            builder.Services.AddDbContext<StoreDbContext>(options =>
                options.UseSqlServer(builder.Configuration["ConnectionStrings:Microservices.GraphQL"]));

            builder.Services.AddGraphQLServer().AddQueryType<StoreQuery>().AddProjections().AddFiltering().AddSorting();

            /******************************************************************************************************************************************/

            var app = builder.Build();
            app.UseCors("AllowAll");            
            app.MapGraphQL("/graphql");            
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