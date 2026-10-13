
using OrientacaoObjetos.NotificactionContext;

namespace OrientacaoObjetos.sharedContext;

public abstract class Base : Notifiable
{
    public Base()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
}
