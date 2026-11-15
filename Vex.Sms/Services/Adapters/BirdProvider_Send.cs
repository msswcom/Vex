using System.Text.Json;
using Vex.Models.Provider;
using Vex.Sms.Providers;
using Vex.Sms.Services.Interfaces;
namespace Vex.Sms.Services.Adapters;

internal partial class BirdProvider : IProvider
{
    public string Send(string text, string recipient)
    {
        string? response;

        var smsMessage = new SmsMessage
        {
            From = MessageSender.Multimedia,
            To = recipient,
            Text = text,
            Category = MessageCategory.Marketing
        };

        var message = Http.PostAsJsonAsync($"{MessageBirdAPI.Base}/{MessageBirdAPI.SmsMessages}", smsMessage);

        response = JsonSerializer.Serialize(message);

        return response;
    }
}
