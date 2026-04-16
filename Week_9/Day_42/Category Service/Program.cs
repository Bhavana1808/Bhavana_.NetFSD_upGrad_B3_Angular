
using CategoryService.API.Data;
using CategoryService.API.Models;
using CategoryService.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace CategoryService.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<CategoryDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services to the container.

            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
