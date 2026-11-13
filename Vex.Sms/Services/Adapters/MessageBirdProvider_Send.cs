using System.Text.Json;
using Vex.Sms.Providers;
using Vex.Sms.Services.Interfaces;
namespace Vex.Sms.Services.Adapters;

internal partial class MessageBirdProvider : IProvider
{
    public string Send(string text, long[] recipients)
    {
        string? response;

        try
        {
            var message = client.SendMessage(MessageBirdAPI.Telephone!, text, recipients);

            response = JsonSerializer.Serialize(message);
        }
        catch
        {
            response = "Error sending to MessageBird. New Bird.com API is available which is not free.";
        }

        return response;
    }
}
