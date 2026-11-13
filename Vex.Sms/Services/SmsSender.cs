using Vex.Orchestrator.Services.Out.Interfaces;
using Vex.Sms.Services.Interfaces;
namespace Vex.Sms.Services;

public class SmsSender(IProvider provider) : ISmsSender
{
    public string Send(string text, long[] recipients)
    {
        var message = provider.Send(text, recipients);

        return message;
    }
}
