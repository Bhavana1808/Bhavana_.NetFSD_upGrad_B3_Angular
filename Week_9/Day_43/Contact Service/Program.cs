using Microsoft.EntityFrameworkCore;
using ContactService.API.Models;
using ContactService.API.Repository;
using ContactService.API.Data;
namespace ContactService.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddDbContext<ContactDbContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Add services to the container.

        builder.Services.AddScoped<IContactRepository, ContactRepository>();

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