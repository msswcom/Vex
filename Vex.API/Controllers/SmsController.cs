using Microsoft.AspNetCore.Mvc;
using Vex.Orchestrator.Services.In.Interfaces;
namespace Vex.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class SmsController(ICreditNotificationSender creditNotificationSender) : ControllerBase
{
    [HttpPost]
    public async Task<string> Send(string creditNumber, long templateID)
    {
        return await creditNotificationSender.SendAsync(creditNumber, templateID);
    }
}
