using System.Text.Json;
using Vex.Sms.Providers;
using Vex.Sms.Services.Interfaces;
namespace Vex.Sms.Services.Adapters;

internal partial class MessageBirdProvider : IProvider
{
    public string Send(string text, string recipient)
    {
        string? response;

        var message = client.SendMessage(MessageBirdAPI.Telephone!, text, [Convert.ToInt64(recipient)]);

        response = JsonSerializer.Serialize(message);

        return response;
    }
}
