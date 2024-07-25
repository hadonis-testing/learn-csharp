using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace CS17.Controllers.v2
{
    [ApiController]
    [ApiVersion(2.0)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from v2");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Hello from v2");
        }
    }
}
