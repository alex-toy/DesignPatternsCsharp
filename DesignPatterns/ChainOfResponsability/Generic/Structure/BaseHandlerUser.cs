namespace ChainOfResponsability.Generic.Structure;

public abstract class BaseHandlerUser<T>
{
    public required Handler<T> Handler { get; set; }

    public void Handle(T request)
    {
        Handler.Handle(request);
    }
}
