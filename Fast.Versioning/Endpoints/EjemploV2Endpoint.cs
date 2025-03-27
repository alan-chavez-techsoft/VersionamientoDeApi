using FastEndpoints.AspVersioning;

namespace FastEndpoints.Versioning.Endpoints
{
    public class EjemploV2Endpoint : EndpointWithoutRequest<string>
    {
        public override void Configure()
        {
            Get("api/ejemplo");
            AllowAnonymous();
            Options(x => x.WithVersionSet("ApiEjemplo")
            .MapToApiVersion(2.0));
            //Version(2);
        }
        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendOkAsync("Ejemplo V2", ct);
        }
    }
}
