namespace Vex.Sms.Services.Interfaces;

public interface IProvider
{
    string Send(string text, string recipient);
}
