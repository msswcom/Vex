using System.Net.Http.Headers;
using Vex.Sms.Providers;
using Vex.Sms.Services.Interfaces;
namespace Vex.Sms.Services.Adapters;

internal partial class BirdProvider : IProvider
{
    HttpClient Http { get; }

    public BirdProvider(HttpClient httpClient)
    {
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MessageBirdAPI.Key);

        Http = httpClient;
    }
}
