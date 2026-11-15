using Microsoft.Extensions.DependencyInjection;
using Vex.Orchestrator.Services.Out.Interfaces;
using Vex.Sms.Services;
using Vex.Sms.Services.Adapters;
using Vex.Sms.Services.Interfaces;
namespace Vex.Sms;

public static class ServiceComposer
{
    public static IServiceCollection AddSms(this IServiceCollection services)
    {
        services.AddHttpClient<BirdProvider>();
        services.AddTransient<IProvider, BirdProvider>();
        services.AddTransient<ISmsSender, SmsSender>();

        return services;
    }
}
