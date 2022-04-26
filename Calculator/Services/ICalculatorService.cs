namespace Calculator.Services
{
    public interface ICalculatorService
    {
        Task<decimal> Add(decimal value1, decimal value2, string? sessionId);

        Task<decimal> Substract(decimal value1, decimal value2, string? sessionId);

        Task<decimal> Multiply(decimal value1, decimal value2, string? sessionId);

        Task<decimal> Divide(decimal value1, decimal value2, string? sessionId);
    }
}
