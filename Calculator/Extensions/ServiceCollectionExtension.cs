using Calculator.Services;

namespace Calculator.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICalculatorService, CalculatorService>();

            services.AddScoped<IMemoryService, MemoryService>();
        }
    }
}
