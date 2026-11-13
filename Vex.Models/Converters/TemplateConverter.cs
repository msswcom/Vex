using Vex.Models.Database;
namespace Vex.Models.Converters;

public class TemplateConverter
{
    public static string Convert(Credit credit, string template)
    {
        var text = template;

        foreach (var property in Credit.Properties)
        {
            text = text.Replace($"{{{property}}}", credit.Property(property));
        }

        return text;
    }
}
