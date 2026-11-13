namespace Vex.Orchestrator.Services.Out.Interfaces;

public interface ITemplates
{
    Task<string> GetAsync(long id);
}
