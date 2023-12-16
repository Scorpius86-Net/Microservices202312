using Grpc.Core;
using Microservices.gRPC.API.Protos;

namespace Microservices.gRPC.Client.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                        
            builder.Services.AddControllersWithViews();
            builder.Services.AddGrpcClient<Products.ProductsClient>(options => {
                options.Address = new Uri("https://localhost:7004");                
            });

            /*****************************************************************************************************************/

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}