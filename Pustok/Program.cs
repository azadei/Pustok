using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

namespace Pustok
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //boiler-plate
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddControllersWithViews();
            


            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute("default", "{controller}/{action}");
            app.Run();
        }
    }
}


  