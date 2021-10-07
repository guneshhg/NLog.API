using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {

            _logger.LogTrace("Trace girildi.");
            _logger.LogInformation("Information girildi.");
            _logger.LogWarning("Warning girildi");
            _logger.LogError("Error girildi.");
            _logger.LogCritical("Critical girildi.");

            return Ok();
        }


    }
}
