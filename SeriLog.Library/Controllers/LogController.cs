using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace SeriLog.Library.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {

        [HttpPost("test-logger")]
        public IActionResult TestLogger()
        {
            Log.Information("Test log");
            return Ok();
        }

    }
}
