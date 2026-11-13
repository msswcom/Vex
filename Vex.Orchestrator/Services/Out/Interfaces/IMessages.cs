using Vex.Models.Database;
namespace Vex.Orchestrator.Services.Out.Interfaces;

public interface IMessages
{
    Task<Message> InsertAsync(Message message);
}
