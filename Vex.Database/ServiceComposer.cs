using Microsoft.Extensions.DependencyInjection;
using Vex.Database.Contexts;
using Vex.Database.Services;
using Vex.Database.Services.Adapters;
using Vex.Orchestrator.Services.Out.Interfaces;
namespace Vex.Database;

public static class ServiceComposer
{
    public static IServiceCollection AddDatabase(this IServiceCollection services)
    {
        services.AddTransient<VexAdapter>();
        services.AddTransient<VexContext>();

        services.AddTransient<ICredits, Credits>();
        services.AddTransient<IMessages, Messages>();
        services.AddTransient<ITemplates, Templates>();

        return services;
    }
}
