namespace Vex.Sms.Providers;

public static class MessageBirdAPI
{
    public const string Base = "https://eu1.platform.bird.com/v1";
    public const string SmsMessages = "sms/messages";

    public static string? Key { get; set; }
    public static string? Telephone { get; set; }
}
