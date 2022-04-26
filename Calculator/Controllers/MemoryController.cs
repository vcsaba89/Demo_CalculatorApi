using Calculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemoryController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMemoryService _memory;

        public MemoryController(ILoggerFactory loggerFactory, IMemoryService memoryService)
        {
            _logger = loggerFactory.CreateLogger<CalculatorController>();

            _memory = memoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<decimal>>> Get(string sessionId)
        {
            List<decimal> result = new List<decimal>();

            try
            {
                var res = (await _memory.GetResults(sessionId)).ToList();

                result.AddRange(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

            return Ok(result);
        }
    }
}
