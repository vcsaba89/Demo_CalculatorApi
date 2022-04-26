namespace Calculator.Services
{
    public interface IMemoryService
    {
        Task StoreResult(string sessionId, decimal result);

        Task<IEnumerable<decimal>> GetResults(string sessionId);
    }
}
