using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NLog.Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {

        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
            //_logger.LogDebug(1, "NLog enjected into LogController");
        }

        [HttpGet("[action]")]
        public IActionResult Get()
        {
            //_logger.LogInformation("Hello, this is the GetApi Log");
            int x = 0;
            int y = 0;
            try
            {
                int result = x / y;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Bir hata alındı.");
                return BadRequest();
            }
            return NoContent();
        }

    }
}
