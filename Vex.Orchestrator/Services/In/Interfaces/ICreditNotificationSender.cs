namespace Vex.Orchestrator.Services.In.Interfaces;

public interface ICreditNotificationSender
{
    /// <summary>
    /// Sends notification for creditNumber using the template from the Templates table
    /// </summary>
    /// <param name="creditNumber"></param>
    /// <param name="templateID"></param>
    /// <returns>response message</returns>
    Task<string> SendAsync(string creditNumber, long templateID);
}
