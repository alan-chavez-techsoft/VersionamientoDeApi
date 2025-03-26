using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.Versioning.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/ejemplo")]
    [ApiController]
    public class EjemploV2Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Ejemplo V2";
        }
    }
}
