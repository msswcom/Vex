using Microsoft.EntityFrameworkCore;
using Vex.Database.Contexts;
using Vex.Models.Database;
using Vex.Models.Exceptions;
using Vex.Orchestrator.Services.Out.Interfaces;
namespace Vex.Database.Services;

internal class Credits(VexContext context) : ICredits
{
    public async Task<Credit> GetAsync(string number)
    {
        var credit = await context.Credits.FirstOrDefaultAsync(o => o.Number == number)
            ?? throw new NotFoundException(nameof(Credit), number);

        return credit;
    }
}
