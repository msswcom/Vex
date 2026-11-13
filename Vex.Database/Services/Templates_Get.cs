using Vex.Database.Contexts;
using Vex.Models.Database;
using Vex.Models.Exceptions;
using Vex.Orchestrator.Services.Out.Interfaces;
namespace Vex.Database.Services;

internal class Templates(VexContext context) : ITemplates
{
    public async Task<string> GetAsync(long id)
    {
        var template = await context.Templates.FindAsync(id)
            ?? throw new NotFoundException(nameof(Template), id.ToString());

        return template.Text;
    }
}
