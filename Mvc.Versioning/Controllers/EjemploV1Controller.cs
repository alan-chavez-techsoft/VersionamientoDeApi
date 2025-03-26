using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.Versioning.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/ejemplo")]
    [ApiController]
    public class EjemploV1Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Ejemplo V1";
        }
    }
}
