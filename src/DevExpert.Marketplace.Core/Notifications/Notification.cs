namespace DevExpert.Marketplace.Core.Notifications;

public class Notification
{
    public Notification(string message)
    {
        Message = message;
    }

    public string? Message { get; }
}