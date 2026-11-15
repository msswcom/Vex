using System.Text.Json.Serialization;
namespace Vex.Models.Provider;

public class SmsMessage
{
    [JsonPropertyName("to")]
    public required string To { get; set; }
    [JsonPropertyName("from")]
    public required string From { get; set; }
    [JsonPropertyName("text")]
    public required string Text { get; set; }
    [JsonPropertyName("category")]
    public required string Category { get; set; }
}
