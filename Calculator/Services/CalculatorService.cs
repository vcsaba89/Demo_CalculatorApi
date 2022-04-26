namespace Calculator.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IMemoryService _memory;

        public CalculatorService(IMemoryService memoryService)
        {
            _memory = memoryService;
        }

        public async Task<decimal> Add(decimal value1, decimal value2, string? sessionId)
        {
            var result = value1 + value2;
            if (!string.IsNullOrWhiteSpace(sessionId))
            {
                await _memory.StoreResult(sessionId, result);
            }

            return await Task.FromResult(result);
        }

        public async Task<decimal> Substract(decimal value1, decimal value2, string? sessionId)
        {
            var result = value1 - value2;
            if (!string.IsNullOrWhiteSpace(sessionId))
            {
                await _memory.StoreResult(sessionId, result);
            }

            return await Task.FromResult(result);
        }

        public async Task<decimal> Multiply(decimal value1, decimal value2, string? sessionId)
        {
            var result = value1 * value2;
            if (!string.IsNullOrWhiteSpace(sessionId))
            {
                await _memory.StoreResult(sessionId, result);
            }

            return await Task.FromResult(result);
        }

        public async Task<decimal> Divide(decimal value1, decimal value2, string? sessionId)
        {
            var result = value1 / value2;
            if (!string.IsNullOrWhiteSpace(sessionId))
            {
                await _memory.StoreResult(sessionId, result);
            }

            return await Task.FromResult(result);
        }
    }
}
