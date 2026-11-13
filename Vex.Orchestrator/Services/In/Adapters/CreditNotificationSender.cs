using Vex.Models.Converters;
using Vex.Models.Database;
using Vex.Orchestrator.Services.In.Interfaces;
using Vex.Orchestrator.Services.Out.Interfaces;
namespace Vex.Orchestrator.Services.In.Adapters;

internal class CreditNotificationSender(
    ISmsSender smsSender,
    ICredits credits,
    IMessages messages,
    ITemplates templates)
    : ICreditNotificationSender
{
    public async Task<string> SendAsync(string creditNumber, long templateID)
    {
        var credit = await credits.GetAsync(creditNumber);
        var template = await templates.GetAsync(templateID);

        var text = TemplateConverter.Convert(credit, template);

        var response = smsSender.Send(text, [Convert.ToInt64(credit.CustomerPhone)]);

        await messages.InsertAsync(new Message
        {
            CreditNumber = creditNumber,
            Text = response
        });

        return $"{response} {text}";
    }
}
