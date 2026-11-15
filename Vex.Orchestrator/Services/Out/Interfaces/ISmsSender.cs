namespace Vex.Orchestrator.Services.Out.Interfaces;

public interface ISmsSender
{
    string Send(string text, string recipient);
}
