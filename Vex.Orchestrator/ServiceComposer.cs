using Microsoft.Extensions.DependencyInjection;
using Vex.Orchestrator.Services.In.Adapters;
using Vex.Orchestrator.Services.In.Interfaces;
namespace Vex.Orchestrator;

public static class ServiceComposer
{
    public static IServiceCollection AddOrchestrator(this IServiceCollection services)
    {
        services.AddTransient<ICreditNotificationSender, CreditNotificationSender>();

        return services;
    }
}
