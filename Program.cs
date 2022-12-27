
using Microsoft.EntityFrameworkCore;
using Villa_API;
using Villa_API.Data;
using Villa_API.Repository;

internal class Program
 
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<Applicaitondbcontext>(option =>
        {
            option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
        });

        builder.Services.AddAutoMapper(typeof(MappingConfig));
        //{
        //    option.ReturnHttpNotAcceptable = true;
        //}).AddNewtonsoftJson();

        //  Log.Logger = new LoggerConfiguration().MinimumLevel.Error().WriteTo.File("log/villlaLogs.txt",rollingInterval: RollingInterval.Day).CreateLogger(); 
        // Add services to the container.

        // builder.Host.UseSerilog();
  //      builder.Services.AddScoped<IVillaReposiroty, VillaRepository>;
        builder.Services.AddControllers().AddNewtonsoftJson();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        ControllerActionEndpointConventionBuilder controllerActionEndpointConventionBuilder = app.MapControllers();

        app.Run();
    }
}