using BusinessLogicInterface;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic;

public static class ServiceCollectionExtension
{
    public static void AddBusinessLogicService(this IServiceCollection services)
    {
        services.AddScoped<ISafeMathManager, SafeMathManager>();
    }
}