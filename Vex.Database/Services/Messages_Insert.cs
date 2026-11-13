using Vex.Database.Services.Adapters;
using Vex.Models.Database;
using Vex.Orchestrator.Services.Out.Interfaces;
namespace Vex.Database.Services;

internal class Messages(VexAdapter adapter) : IMessages
{
    public async Task<Message> InsertAsync(Message message)
    {
        message = await adapter.InsertAsync(message);

        return message;
    }
}
