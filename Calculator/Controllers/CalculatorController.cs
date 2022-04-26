using Calculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly ICalculatorService _calculator;

        public CalculatorController(ILoggerFactory loggerFactory, ICalculatorService calculatorService)
        {
            _logger = loggerFactory.CreateLogger<CalculatorController>();

            _calculator = calculatorService;
        }

        [HttpGet(nameof(Add))]
        public async Task<ActionResult<decimal>> Add(decimal value1, decimal value2, string? sessionId)
        {
            decimal result = 0;

            try
            {
                result = await _calculator.Add(value1, value2, sessionId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

            return Ok(result);
        }

        [HttpGet(nameof(Substract))]
        public async Task<ActionResult<decimal>> Substract(decimal value1, decimal value2, string? sessionId)
        {
            decimal result = 0;

            try
            {
                result = await _calculator.Substract(value1, value2, sessionId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

            return Ok(result);
        }

        [HttpGet(nameof(Multiply))]
        public async Task<ActionResult<decimal>> Multiply(decimal value1, decimal value2, string? sessionId)
        {
            decimal result = 0;

            try
            {
                result = await _calculator.Multiply(value1, value2, sessionId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

            return Ok(result);
        }

        [HttpGet(nameof(Divide))]
        public async Task<ActionResult<decimal>> Divide(decimal value1, decimal value2, string? sessionId)
        {
            decimal result = 0;

            try
            {
                result = await _calculator.Divide(value1, value2, sessionId);
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
