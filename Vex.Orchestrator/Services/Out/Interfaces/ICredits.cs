using Vex.Models.Database;
namespace Vex.Orchestrator.Services.Out.Interfaces;

public interface ICredits
{
    Task<Credit> GetAsync(string number);
}
