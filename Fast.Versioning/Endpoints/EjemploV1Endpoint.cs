using FastEndpoints.AspVersioning;

namespace FastEndpoints.Versioning.Endpoints
{
    public class EjemploV1Endpoint: EndpointWithoutRequest<string>
    {
        public override void Configure()
        {
            Get("api/ejemplo");
            AllowAnonymous();
            //Aqui se le asigna la version y el "proceso" al endpoint
            Options(x => x.WithVersionSet("Ejemplo")
            .MapToApiVersion(1.0));
        }
        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendOkAsync("Ejemplo V1", ct);
        }
    }
}
