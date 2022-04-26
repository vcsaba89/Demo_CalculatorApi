namespace Calculator.Services
{
    public class MemoryService : IMemoryService
    {
        public static Dictionary<string, List<decimal>> Memory { get; set; } = new Dictionary<string, List<decimal>>();

        public async Task StoreResult(string sessionId, decimal result)
        {
            if (Memory.ContainsKey(sessionId))
            {
                Memory[sessionId].Add(result);
                return;
            }

            Memory.Add(sessionId, new List<decimal> { result });
        }

        public async Task<IEnumerable<decimal>> GetResults(string sessionId)
        {
            return await Task.FromResult(Memory[sessionId]);
        }
    }
}
