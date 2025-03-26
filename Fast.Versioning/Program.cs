
using Asp.Versioning;
using Asp.Versioning.Conventions;
using FastEndpoints;
using FastEndpoints.AspVersioning;

namespace Fast.Versioning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //Configuracion para usar versionamiento en fastendpoints
            builder.Services.AddFastEndpoints()
            .AddVersioning(o =>
            {
                o.DefaultApiVersion = new(1.0);
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.ApiVersionReader = new HeaderApiVersionReader("X-Api-Version");
            });
            //Se declaran las versiones de un endpoint o de un "proceso"
            VersionSets.CreateApi("Ejemplo", v => v
            .HasApiVersion(1.0)
            .HasApiVersion(2.0));

            var app = builder.Build();

            //Declaracion de FastEndpoints
            app.UseFastEndpoints(c =>
            {
                c.Versioning.Prefix = "v";
            }).UseSwaggerUI();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
