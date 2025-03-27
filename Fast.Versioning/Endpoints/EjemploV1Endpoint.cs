using FastEndpoints.AspVersioning;

namespace FastEndpoints.Versioning.Endpoints
{
    public class EjemploV1Endpoint: EndpointWithoutRequest<string>
    {
        public override void Configure()
        {
            Get("api/ejemplo");
            AllowAnonymous();
            Options(x => x.WithVersionSet("ApiEjemplo")
            .MapToApiVersion(1.0));
            //Version(1);

        }
        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendOkAsync("Ejemplo V1", ct);
        }
    }
}
