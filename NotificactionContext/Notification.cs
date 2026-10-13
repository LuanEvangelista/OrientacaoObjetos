namespace OrientacaoObjetos.NotificactionContext;

public sealed class Notification
{
    public Notification() { }

    public Notification(string property, string message)
    {
        Message = message;
        Property = property;
    }

    public string Message { get; set; }

    public string Property { get; set; }

}
