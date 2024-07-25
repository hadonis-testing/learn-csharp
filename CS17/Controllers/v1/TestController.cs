using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace CS17.Controllers.v1
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from v1");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Hello from v1");
        }
    }
}
