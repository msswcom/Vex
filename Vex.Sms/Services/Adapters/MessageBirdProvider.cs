using MessageBird;
using Vex.Sms.Providers;
using Vex.Sms.Services.Interfaces;
namespace Vex.Sms.Services.Adapters;

internal partial class MessageBirdProvider : IProvider
{
    readonly Client client = Client.CreateDefault(MessageBirdAPI.Key
        ?? throw new ArgumentNullException("MessageBirdAPI Key not set"));
}
